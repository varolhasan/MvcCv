using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class DeneyimlerController : Controller
    {
        // GET: Deneyimler
        DeneyimlerimRepository repo = new DeneyimlerimRepository();
        
        [Authorize]
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(TBLDENEYIM p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeneyimSil(int id)
        {
            TBLDENEYIM t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            TBLDENEYIM t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult DeneyimGetir(TBLDENEYIM p)
        {
            TBLDENEYIM t = repo.Find(x => x.ID == p.ID);
            t.BASLIK = p.BASLIK;
            t.ALTBASLIK = p.ALTBASLIK;
            t.ACIKLAMA = p.ACIKLAMA;
            t.TARIH = p.TARIH;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}