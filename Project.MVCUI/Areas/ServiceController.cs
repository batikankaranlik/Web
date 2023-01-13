using Project.BLL.DesignPatterns.genericRepository.ConcRep;
using Project.COMMON.Tools;
using Project.ENTITIES.Models;
using Project.MVCUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas
{
    public class ServiceController : Controller
    {
        ServiceRepository _sRep;
        public ServiceController()
        {
            _sRep = new ServiceRepository();
        }
        // GET: Service
        public ActionResult ListService()
        {
            ServiceVM svm = new ServiceVM();
            svm.Services = _sRep.GetAll();
            return View(svm);
        }
        public ActionResult AddService()
        {
            ServiceVM svm = new ServiceVM();
            svm.Service = new Service();
            return View(svm);
        }
        [HttpPost]
        public ActionResult AddService(Service service, HttpPostedFileBase resim)
        {
            service.Icon = ImageUploader.UploadImage("/Pictures", resim);
            _sRep.Add(service);
            return RedirectToAction("ListService");
        }
        public ActionResult UpdateService(int id)
        {
            ServiceVM svm = new ServiceVM();
            svm.Service = _sRep.Find(id);
            return View(svm);
        }
        [HttpPost]
        public ActionResult UpdateService(Service service, HttpPostedFileBase resim)
        {
            if (resim == null)
            {
                service.Icon = _sRep.Find(service.ID).Icon;
            }
            else
            {
                service.Icon = ImageUploader.UploadImage("/Pictures", resim);
            }
            _sRep.Update(service);
            return RedirectToAction("ListService");
        }
        public ActionResult DeleteService(int id)
        {
            _sRep.Delete(_sRep.Find(id));
            return RedirectToAction("ListService");
        }

    }
}