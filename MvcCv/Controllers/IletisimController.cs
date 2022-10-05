using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        DbCvEntities db = new DbCvEntities();
        IletisimRepository repo = new IletisimRepository();
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        public ActionResult IletisimSil(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            return View(deger);
        }
    }
}