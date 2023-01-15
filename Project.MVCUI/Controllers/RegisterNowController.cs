using MVCMailService.Tools;
using Project.BLL.DesignPatterns.genericRepository.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class RegisterNowController : Controller
    {
        AppUserRepository _aRep;
        public RegisterNowController()
        {
            _aRep = new AppUserRepository();
        }
        // GET: RegisterNow
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(AppUser appUser)
        {
            if (_aRep.Any(x=>x.UserName==appUser.UserName))
            {
                ViewBag.ZatenVar = "Kullanıcı ismi daha önce alınmış";
                return View();
            }
            if (_aRep.Any(x=>x.Email==appUser.Email))
            {
                ViewBag.ZatenVar = "E-Mail  daha önce Kullanılmış";
                return View();
            }
          //  string gonderilecekEmail = "Tebrikler ... Hesabınız oluştu ";
           // MailService.send(appUser.Email, body: gonderilecekEmail, subject: "Hesap ");
            _aRep.Add(appUser);
            return RedirectToAction("LoginPage", "Login");
        }
    }
}