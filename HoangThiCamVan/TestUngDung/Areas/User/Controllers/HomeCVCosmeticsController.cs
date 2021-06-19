using ModelEF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Areas.User.Controllers
{
    public class HomeCVCosmeticsController : Controller
    {
        // GET: User/HomeCVCometics
        public ActionResult Index()
        {
            var productDao = new ProductDao();
            ViewBag.NewCategory1 = productDao.ListCategory1(4);
            ViewBag.NewCategory2 = productDao.ListCategory2(4);
            ViewBag.NewCategory3 = productDao.ListCategory3(4);
            ViewBag.NewCategory4 = productDao.ListCategory4(4);
            ViewBag.NewCategory7 = productDao.ListCategory7(4);
            return View();
        }
    }
}