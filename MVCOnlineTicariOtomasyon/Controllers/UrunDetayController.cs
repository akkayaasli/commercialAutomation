using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCOnlineTicariOtomasyon.Models.Sınıflar;
namespace MVCOnlineTicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        Context c = new Context();
        // GET: UrunDetay
        public ActionResult Index()
        {
            Class2 cs = new Class2();
            cs.Deger1 = c.Uruns.Where(x => x.Urunid == 2).ToList();
            cs.Deger2 = c.Detays.Where(x => x.DetayID == 2).ToList();
            
            return View(cs);
        }
    }
}