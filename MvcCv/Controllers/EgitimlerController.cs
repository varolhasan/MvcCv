using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class EgitimlerController : Controller
    {
        // GET: Egitimler
        DbCvEntities db = new DbCvEntities();
        EgitimlerimRepository repo = new EgitimlerimRepository();
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(TBLEGITIM p)
        {
            if (!ModelState.IsValid)
            {
                return View("EğitimEkle");
            }
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult EgitimSil(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            repo.TDelete(deger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EgitimGuncelle(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult EgitimGuncelle(TBLEGITIM p)
        {
            var deger = repo.Find(x => x.ID == p.ID);
            deger.BASLIK = p.BASLIK;
            deger.ALTBASLIK1 = p.ALTBASLIK1;
            deger.ALTBASLIK2 = p.ALTBASLIK2;
            deger.GNO = p.GNO;
            deger.TARIH = p.TARIH;
            repo.TUpdate(deger);
            return RedirectToAction("Index");
        }
    }
}