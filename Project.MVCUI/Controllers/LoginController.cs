using Project.BLL.DesignPatterns.genericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class LoginController : Controller
    {
        AppUserRepository _aRep;
        public LoginController()
        {
            _aRep = new AppUserRepository();
        }
        // GET: Login
        public ActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginPage(AppUser appUser)
        {
            AppUser ap = _aRep.FirstOrDefault(x => x.UserName == appUser.UserName && x.Password == appUser.Password);

            if (ap!=null)
            {
                if (ap.Role== ENTITIES.Enums.UserRole.Member)
                {
                    Session["member"] = ap;
                    return RedirectToAction("Index", "HomePage");
                }
                else if (ap.Role==ENTITIES.Enums.UserRole.Admin)
                {
                    Session["admin"] = ap;
                    return RedirectToAction("AdminPage", "Admin");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "HomePage");
        }

    }
}