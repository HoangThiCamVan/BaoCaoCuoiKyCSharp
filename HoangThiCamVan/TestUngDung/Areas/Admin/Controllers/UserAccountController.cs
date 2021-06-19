using ModelEF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Areas.Admin.Controllers
{
    public class UserAccountController : BaseController
    {
        // GET: Admin/UserAccount
        UserDao db = new UserDao();
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            var dmsp = new UserDao();
            var model = dmsp.ListWhereAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        //public ActionResult Index()
        //{
        //    var user = new UserDao();
        //    var model = user.ListAll();
        //    return View(model);
        //}

        public ActionResult Delete(int id)
        {
            new UserDao().Delete(id);
            return RedirectToAction("Index");
        }
    }
}