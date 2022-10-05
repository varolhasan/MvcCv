using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class YeteneklerController : Controller
    {
        // GET: Yetenekler
        DbCvEntities db = new DbCvEntities();
        YetenekRepository repo = new YetenekRepository();
        public ActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YetenekEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YetenekEkle(TBLYETENEK p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            repo.TDelete(deger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGuncelle(int id)
        {
            var deger = repo.Find(x => x.ID == id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult YetenekGuncelle(TBLYETENEK p)
        {
            var deger = repo.Find(x => x.ID == p.ID);
            deger.YETENEK = p.YETENEK;
            deger.ORAN = p.ORAN;
            repo.TUpdate(deger);
            return RedirectToAction("Index");
        }
    }
}