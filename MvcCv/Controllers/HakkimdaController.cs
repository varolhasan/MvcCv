using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        DbCvEntities db = new DbCvEntities();
        HakkimdaRepository repo = new HakkimdaRepository();
        [HttpGet]
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpPost]
        public ActionResult Index(TBLHAKKIMDA p)
        {
            var deger = repo.Find(x => x.ID == 1);
            deger.AD = p.AD;
            deger.SOYAD = p.SOYAD;
            deger.ADRES = p.ADRES;
            deger.TELEFON = p.TELEFON;
            deger.MAIL = p.MAIL;
            deger.ACIKLAMA = p.ACIKLAMA;
            deger.FOTOGRAF = p.FOTOGRAF;
            repo.TUpdate(deger);
            return RedirectToAction("Index");
        }
    }
}