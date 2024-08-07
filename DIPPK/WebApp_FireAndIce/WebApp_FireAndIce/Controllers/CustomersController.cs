using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_FireAndIce.ActionFilters;
using WebApp_FireAndIce.Models;
using WebApp_FireAndIce.Repositories;
using WebApp_FireAndIce.ViewModels.Customers;


namespace WebApp_FireAndIce.Controllers
{
    [AuthenticationFilter]
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();

            IndexVM model = new IndexVM();
            model.Items = context.Customers.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            Customer item = new Customer();
            item.Username = model.Username;
            item.Password = model.Password;
            item.Requests = new List<Request>();

            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();
            context.Customers.Add(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();
            Customer item = context.Customers.Where(u => u.Id == id)
                                     .FirstOrDefault();

            if (item == null)
                return RedirectToAction("Index", "Customers");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Username = item.Username;
            model.Password = item.Password;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();

            if (!ModelState.IsValid)
                return View(model);

            Customer item = context.Customers.Where(u => u.Id == model.Id)
                                     .FirstOrDefault();
            item.Username = model.Username;
            item.Password = model.Password;

            context.Customers.Update(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public IActionResult Delete(int id)
        {
            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();
            Customer item = new Customer();
            item.Id = id;

            context.Customers.Remove(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }
    }
}
