using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_FireAndIce.ActionFilters;
using WebApp_FireAndIce.Models;
using WebApp_FireAndIce.Repositories;
using WebApp_FireAndIce.ViewModels.Requests;
using WebApp_FireAndIce.ExtentionMethods;


namespace WebApp_FireAndIce.Controllers
{
    [AuthenticationFilter]
    public class RequestsController : Controller
    {
        public IActionResult Index()
        {
            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();

            IndexVM model = new IndexVM();
            model.Items = context.Requests.ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Customer loggedCustomer = this.HttpContext.Session.GetObject<Customer>("loggedUser");
            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();

            CreateVM model = new CreateVM();
            model.CustomerId = loggedCustomer.Id;

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            Customer loggedCustomer = this.HttpContext.Session.GetObject<Customer>("loggedUser");
            if (!ModelState.IsValid)
                return View(model);

            Request item = new Request();
            item.Name = model.Name;
            item.Description = model.Description;
            item.Address = model.Adress;
            model.CustomerId = loggedCustomer.Id;
            item.CustomerId = model.CustomerId;
            item.Status = "изчакваща";

            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();
            context.Requests.Add(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Requests");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Customer loggedCustomer = this.HttpContext.Session.GetObject<Customer>("loggedUser");

            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();
            Request item = context.Requests.Where(u => u.Id == id)
                                     .FirstOrDefault();

            if (item == null)
                return RedirectToAction("Index", "Requests");

            EditVM model = new EditVM();
            model.Id = item.Id;
            model.Name = item.Name;
            model.Description = item.Description;
            model.Adress = item.Address;
            model.Status = item.Status;
            model.DateOfVisit = item.DateOfVisit;
            model.RespTechId = item.RespTech.Id;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();

            if (!ModelState.IsValid)
                return View(model);

            Request item = context.Requests.Where(u => u.Id == model.Id)
                                     .FirstOrDefault();
            item.Name = model.Name;
            item.Description = model.Description;
            item.Address = model.Adress;
            item.Status = model.Status;
            item.DateOfVisit = model.DateOfVisit;
            item.RespTech = context.Techs.Where(u => u.Id == model.RespTechId).FirstOrDefault();

            context.Requests.Update(item);
            context.SaveChanges();

            return RedirectToAction("Index", "Requests");
        }

        public IActionResult Delete(int id)
        {
            WebApp_FireAndIceDbContext context = new WebApp_FireAndIceDbContext();
            Request item = new Request();
            item = context.Requests.Where(u => u.Id == id).FirstOrDefault();
            if (item.Status == "изчакваща")
            {
                context.Requests.Remove(item); 
            }

            context.SaveChanges();

            return RedirectToAction("Index", "Requests");
        }
    }
}