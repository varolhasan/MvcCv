using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        DbCvEntities db = new DbCvEntities();
        HobiRepository repo = new HobiRepository();
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult HobiEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HobiEkle(TBLHOBI p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult HobiSil(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            repo.TDelete(deger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult HobiGuncelle(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult HobiGuncelle(TBLHOBI p)
        {
            var deger = repo.Find(x => x.ID == p.ID);
            deger.ACIKLAMA1 = p.ACIKLAMA1;
            deger.ACIKLAMA2 = p.ACIKLAMA2;
            repo.TUpdate(deger);
            return RedirectToAction("Index");
        }
    }
}