using Microsoft.AspNetCore.Mvc;
using OOP_Web.Ornekler;

namespace OOP_Web.Controllers
{
    public class DefaultController : Controller
    {
        //void Islemler()
        //{
        //    Class1 c = new Class1();
        //    c.Topla();
        //}
    
        int Topla()
        {
            int s1 = 2;
            int s2 = 3;
            int sonuc = s1 + s2;
            return sonuc;
        }

        int Cevre()
        {
            int kisaKenar = 10;
            int uzunKenar = 20;
            int cevre=2*(kisaKenar+uzunKenar);
            return cevre;
        }
        string Cumle()
        {
            string c = "Küçük hanımlar küçük beyler sizler hepinizi geleceğin birer" +
                "gülü parlayan ışık saçan yıldızı olacaksınız";
            return c;
        }
        void Mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Merhaba Asp.Net ile yardırmaya devam";
            ViewBag.m3 = "Oop'nin içinden geçmeye devam";
        }
        public IActionResult Index()
        {
            Mesajlar();
            return View();
        }
        public IActionResult Urunler()
        {
            Mesajlar();
            ViewBag.t=Topla();
            ViewBag.c = Cevre();
            return View();
        }
        public IActionResult Musteriler()
        {
            ViewBag.d = Cumle();
            return View();
        }
    }
}
