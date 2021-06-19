using ModelEF.DAO;
using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDung.Areas.Admin.Models;

namespace TestUngDung.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        ProductDao db = new ProductDao();
        // GET: Admin/Product
        //public ActionResult Index()
        //{
        //    var pr = new ProductDao();
        //    var model = pr.ListAll();
        //    return View(model);
        //}

        public ActionResult Index(string sortOrder)
        {
            var sanpham = new ProductDao();
            var model = sanpham.LisWheretAll(sortOrder);         
            return View(model);
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            var dao = new CategoryDao();
            ViewBag.DSSanPham = new SelectList(dao.ListAll(), "ID", "Name");
            return View(db.Find(id));
        }
        [HttpPost]
        public ActionResult Detail(Product model)
        {
            db.productDetails(model);
            return RedirectToAction("Index", "SanPham");
        }

        [HttpGet]
        public ActionResult Create()
        {
            var dao = new CategoryDao();
            SetViewBag();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                string result = db.Create(model);
                if (!string.IsNullOrEmpty(result))
                {
                    SetAlert("Tạo Mới Sản Phẩm Thành Công", "success");                   
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    SetAlert("Tạo Mới Sản Phẩm Thất Bại", "error");
                }
            }
            return View(model);
        }
        public void SetViewBag(string selectedCategory = null)
        {
            var dao = new CategoryDao();
            ViewBag.ID = new SelectList(dao.ListAll(), "ID", "Name", selectedCategory);
        }




        
    }
}