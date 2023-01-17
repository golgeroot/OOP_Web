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
            int cevre = 2 * (kisaKenar + uzunKenar);
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

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }
        void Kullaninici(string userName)
        {
            ViewBag.v = userName;
        }
        public IActionResult Index()
        {
            Mesajlar();
            MesajListesi("Paramtre ismi");
            Kullaninici("By GolgeRoot");
            ViewBag.x = Carp(22, 22);
            return View();
        }

        int Carp(int s1, int s2)
        {
            int sonuc = s1 * s2;
            return sonuc;
        }

        int Faktoriyel(int p)
        {
            int f = 1;
            for (int i = 1; i <= p; i++)
            {
                f = f * i;
            }
            return f;
        }
        public IActionResult Urunler()
        {
            Mesajlar();
            Kullaninici("Hacker GolgeRoot");
            ViewBag.t = Topla();
            ViewBag.c = Cevre();
            ViewBag.Faktor = Faktoriyel(9);
            return View();
        }
        public IActionResult Musteriler()
        {
            ViewBag.d = Cumle();
            Kullaninici("GolgeRoot the is Hacker");
            return View();
        }
        public IActionResult Admin()
        {
            Kullaninici("Admin By Golgeroot");
            return View();
        }

        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
            sehirler.Ad = "Adana";
            sehirler.ID = 1;
            sehirler.Nufus = 4753000;
            sehirler.Ulke = "Türkiye";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Sarı";

            ViewBag.v1 = sehirler.ID;
            ViewBag.v2 = sehirler.Ulke;
            ViewBag.v3 = sehirler.Ad;
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v5 =sehirler.Renk1;
            ViewBag.v6 =sehirler.Renk2;
            ViewBag.v7 =sehirler.Renk3;


            sehirler.ID = 2;
            sehirler.Ulke = "Makedonya";
            sehirler.Ad = "Üsküp";
            sehirler.Nufus = 9003223;
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Mavi";
            sehirler.Renk3 = "Ela";
            ViewBag.z1 = sehirler.ID;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.Ad;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;
            ViewBag.z7 = sehirler.Renk3;
            return View();
        }
    }

}
