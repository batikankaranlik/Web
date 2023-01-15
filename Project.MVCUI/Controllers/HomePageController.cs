using Project.BLL.DesignPatterns.genericRepository.ConcRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.ENTITIES.Models;
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
        ContactRepository _cRep;
        // GET: HomePage
        public HomePageController()
        {
            
            _Brep = new BannerRepository();
            _sRep = new ServiceRepository();
            _sProduct = new ProductRepository();
            _sTeam = new TeamRepository();
            _cRep = new ContactRepository();
            
            
        }
        public ActionResult Index()
        {
            HomeVM hmvm = new HomeVM()
            {
                Banner = _Brep.FindLastData(),
                Services = _sRep.GetActives(),
                Products = _sProduct.GetActives(),
                Teams = _sTeam.GetActives(),
                Contact = new Contact(),
                AppUser = Session["Member"] as AppUser,
                

                
            };           
            return View(hmvm);
        }
        [HttpPost]
        public ActionResult AddContact(Contact contact)
        {
            contact.IsClosed = true;
            _cRep.Add(contact);
            return RedirectToAction("Index");
        }
    }
}