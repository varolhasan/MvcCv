using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class SertifikalarController : Controller
    {
        // GET: Sertifikalar
        DbCvEntities db = new DbCvEntities();
        SertifikaRepository repo = new SertifikaRepository();
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult SertifikaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SertifikaEkle(TBLSERTIFIKA p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SertifikaSil(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            repo.TDelete(deger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SertifikaGuncelle(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult SertifikaGuncelle(TBLSERTIFIKA p)
        {
            var deger = repo.Find(x => x.ID == p.ID);
            deger.ACIKLAMA = p.ACIKLAMA;
            repo.TUpdate(deger);
            return RedirectToAction("Index");
        }
    }
}