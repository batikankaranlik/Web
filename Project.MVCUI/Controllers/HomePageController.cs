using Project.BLL.DesignPatterns.genericRepository.ConcRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
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
        protected MyContext _db;
        BannerRepository _Brep;
        // GET: HomePage
        public HomePageController()
        {
            _db = DBTool.DBInstance;
            _Brep = new BannerRepository();
        }
        public ActionResult Index()
        {
            HomeVM hmvm = new HomeVM()
            {
                Banner = _db.Banners.FirstOrDefault()
            };
            return View();
        }
    }
}