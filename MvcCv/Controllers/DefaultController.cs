using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var deger = db.TBLHAKKIMDA.ToList();
            return View(deger);
        }
        public PartialViewResult Hakkimda()
        {
            var deger = db.TBLHAKKIMDA.ToList();
            return PartialView(deger);
        }
        public PartialViewResult SosyalMedya()
        {
            var deger = db.TBLSOSYALMEDYA.ToList();
            return PartialView(deger);
        }
        public PartialViewResult Deneyimlerim()
        {
            var deneyim = db.TBLDENEYIM.ToList();
            return PartialView(deneyim);
        }
        public PartialViewResult Egitimlerim()
        {
            var egitim = db.TBLEGITIM.ToList();
            return PartialView(egitim);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenek = db.TBLYETENEK.ToList();
            return PartialView(yetenek);
        }
        public PartialViewResult Hobilerim()
        {
            var hobi = db.TBLHOBI.ToList();
            return PartialView(hobi);
        }
        public PartialViewResult Sertifikalarım()
        {
            var sertifika = db.TBLSERTIFIKA.ToList();
            return PartialView(sertifika);
        }
        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Iletisim(TBLILETISIM i)
        {
            i.TARIH = DateTime.Parse(DateTime.Now.ToShortDateString());
            var deger = db.TBLILETISIM.Add(i);
            db.SaveChanges();
            return PartialView();
        }
    }
}