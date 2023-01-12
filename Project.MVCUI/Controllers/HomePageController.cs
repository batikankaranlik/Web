using Project.BLL.DesignPatterns.genericRepository.ConcRep;
using Project.BLL.DesignPatterns.SingletonPattern;

using Project.MVCUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    
    public class HomePageController : Controller
    {
        
        BannerRepository _Brep;
        ServiceRepository _sRep;
        ProductRepository _sProduct;
        TeamRepository _sTeam;
        // GET: HomePage
        public HomePageController()
        {
            
            _Brep = new BannerRepository();
            _sRep = new ServiceRepository();
            _sProduct = new ProductRepository();
            _sTeam = new TeamRepository();
        }
        public ActionResult Index()
        {
            HomeVM hmvm = new HomeVM()
            {
                Banner = _Brep.FindLastData(),
                Services=_sRep.GetActives(),
                Products = _sProduct.GetActives(),
                Teams = _sTeam.GetActives(),
                

                
            };
            return View(hmvm);
        }
    }
}