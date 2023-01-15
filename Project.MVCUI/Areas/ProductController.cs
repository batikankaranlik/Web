using Project.BLL.DesignPatterns.genericRepository.ConcRep;
using Project.COMMON.Tools;
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
    public class ProductController : Controller
    {
        ProductRepository _pRep;
        public ProductController()
        {
            _pRep = new ProductRepository();
        }
        // GET: Product
        public ActionResult ListProduct()
        {
            ProductVM prvm = new ProductVM();
            prvm.Products = _pRep.GetAll();
            return View(prvm);
        }

        public ActionResult AddProduct()
        {
            ProductVM prvm = new ProductVM();
            prvm.Product = new Product();
            return View(prvm);
        }
        [HttpPost]
        public ActionResult AddProduct(Product product, HttpPostedFileBase resim)
        {
            product.ImageUrl = ImageUploader.UploadImage("/Pictures", resim);
            _pRep.Add(product);
            return RedirectToAction("ListProduct");
        }

        public ActionResult UpdateProduct(int id)
        {

            ProductVM prvm = new ProductVM();
            prvm.Product = _pRep.Find(id);
            return View(prvm);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product product, HttpPostedFileBase resim)
        {
            if (resim == null)
            {
                product.ImageUrl = _pRep.Find(product.ID).ImageUrl;
            }
            else
            {
                product.ImageUrl = ImageUploader.UploadImage("/Pictures", resim);
            }
            _pRep.Update(product);
            return RedirectToAction("ListProduct");
        }

        public ActionResult DeleteProduct(int id)
        {
            _pRep.Delete(_pRep.Find(id));
            return RedirectToAction("ListProduct");
        }

    }
}