using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TBLADMIN p)
        {
            DbCvEntities db = new DbCvEntities();
            var deger = db.TBLADMIN.FirstOrDefault(x => x.KULLANICI == p.KULLANICI && x.SIFRE == p.SIFRE);
            if (deger != null)
            {
                FormsAuthentication.SetAuthCookie(deger.KULLANICI, false);
                Session["KULLANICI"] = deger.KULLANICI.ToString();
                return RedirectToAction("Index", "Deneyimler");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}