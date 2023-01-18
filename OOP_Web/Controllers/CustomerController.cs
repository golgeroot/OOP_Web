﻿using Microsoft.AspNetCore.Mvc;
using OOP_Web.Entity;
using OOP_Web.ProjeContext;
using System.Linq;

namespace OOP_Web.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            if (p.Name.Length >= 3 && p.City != "" && p.City.Length >= 3)
            {
                context.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Hatalı Giriş";
                return View();
            }

        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Where(x => x.Id == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {

            var value = context.Customers.Where(x => x.Id == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            if (p.Name.Length >= 3 && p.City != "" && p.City.Length >= 3)
            {
                var value = context.Customers.Where(x => x.Id == p.Id).FirstOrDefault();
                value.City = p.City;
                value.Name = p.Name;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
