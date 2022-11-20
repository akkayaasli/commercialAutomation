using MVCOnlineTicariOtomasyon.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOnlineTicariOtomasyon.Controllers
{
    public class CariPanelController : Controller
    {
        // GET: CariPanel
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var mail = (string)Session["CariMail"];
            var degerler = c.Carilers.FirstOrDefault(x => x.CariMail == mail);
            ViewBag.m = mail;
            return View(degerler);
        }
        public ActionResult Siparislerim()
        {
            var mail = (string)Session["CariMail"];
            var id = c.Carilers.Where(x => x.CariMail == 
                                            mail.ToString()).Select(y => y.Cariid).FirstOrDefault();
            //bu id değişkeni ile sisteme giriş yapan mail adresinin id si alındı.
            var degerler = c.SatisHarekets.Where(x => x.Cariid == id).ToList();
            //SatisHarekets tablosunda cariid bu gelen id ye(sisteme giriş yapan) eşitse listele dedik
            return View(degerler);
        }
    }
}