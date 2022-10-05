using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class SosyalController : Controller
    {
        // GET: Sosyal
        DbCvEntities db = new DbCvEntities();
        SosyalRepository repo = new SosyalRepository();
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult SosyalEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SosyalEkle(TBLSOSYALMEDYA p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SosyalSil(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            repo.TDelete(deger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SosyalGuncelle(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult SosyalGuncelle(TBLSOSYALMEDYA p)
        {
            var deger = repo.Find(x => x.ID == p.ID);
            deger.AD = p.AD;
            deger.LINK = p.LINK;
            deger.IKON = p.IKON;
            repo.TUpdate(deger);
            return RedirectToAction("Index");
        }
    }
}