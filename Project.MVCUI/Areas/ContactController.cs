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
    public class ContactController : Controller
    {
        ContactRepository _cRep;
        public ContactController()
        {
            _cRep = new ContactRepository();
        }
        // GET: Contact
        public ActionResult ListContact()
        {
            ContactVM cvm = new ContactVM();
            cvm.Contacts = _cRep.GetAll();
            return View(cvm);
        }
        public ActionResult DeleteProduct(int id)
        {
            _cRep.Delete(_cRep.Find(id));
            return RedirectToAction("ListContact");
        }
        public ActionResult Pasif(int id)
        {
            Contact yakalanan = _cRep.Find(id);
            if (yakalanan.IsClosed == true)
            {
                yakalanan.IsClosed = false;
            }
            else
            {
                yakalanan.IsClosed = true;
            }
            return RedirectToAction("ListContact");
        }
    }
}