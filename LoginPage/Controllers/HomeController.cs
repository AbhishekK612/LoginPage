using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginPage.Models;

namespace LoginPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LoginModal obj = new LoginModal();
            return View(obj);
        }
        [HttpPost]
        public ActionResult Index(LoginModal objuserlogin)
        {
            var display = Userloginvalues().Where(m => m.UserName == objuserlogin.UserName && m.UserPassword == objuserlogin.UserPassword).FirstOrDefault();
            if (display != null)
            {
                ViewBag.Status = "CORRECT UserNAme and Password";
            }
            else
            {
                ViewBag.Status = "INCORRECT UserName or Password";
            }
            return View(objuserlogin);
        }
        public List<LoginModal> Userloginvalues()
        {
            List<LoginModal> objModel = new List<LoginModal>();
            objModel.Add(new LoginModal { UserName = "user1", UserPassword = "password1" });
            objModel.Add(new LoginModal { UserName = "user2", UserPassword = "password2" });
            objModel.Add(new LoginModal { UserName = "user3", UserPassword = "password3" });
            objModel.Add(new LoginModal { UserName = "user4", UserPassword = "password4" });
            objModel.Add(new LoginModal { UserName = "user5", UserPassword = "password5" });
            return objModel;
        }
    }
}
