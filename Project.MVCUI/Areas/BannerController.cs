using Project.BLL.DesignPatterns.genericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.AuthenticationClasses;
using Project.MVCUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas
{
    [AdminAuthentication]
    public class BannerController : Controller
    {
        BannerRepository _bRep;
        public BannerController()
        {
            _bRep = new BannerRepository();
        }
        // GET: Banner
        public ActionResult BannerPage()
        {
            BannerVM bnvm = new BannerVM();
            bnvm.Banners = _bRep.GetActives();
            return View(bnvm);
        }
        public ActionResult AddBanner()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBanner(Banner banner)
        {
            _bRep.Add(banner);
            return RedirectToAction("BannerPage");
        }
        public ActionResult UpdateBanner()
        {
            return View();
        }

        public ActionResult DeleteBanner(int id)
        {
            _bRep.Destroy(_bRep.Find(id));
            return RedirectToAction("BannerPage");
        }

    }
}