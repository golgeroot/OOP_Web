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
    }
}
