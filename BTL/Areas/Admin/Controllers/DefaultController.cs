using BTL.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Admin/Default
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Login(LoginModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var dao = new UserDao();
        //        var result = dao.Login(model.UserName, model.Password);
        //        if (result)
        //        {
        //            Session
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "login unsuccessfully")
        //        }
        //    }

        //    return View("Index");
        //}
    }
}