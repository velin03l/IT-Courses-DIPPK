using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApp_FireAndIce.Models;
using WebApp_FireAndIce.ExtentionMethods;

namespace WebApp_FireAndIce.ActionFilters
{
    public class AuthenticationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetObject<Administrator>("loggedUser") == null)
                context.Result = new RedirectResult("/Home/Login");
            if (context.HttpContext.Session.GetObject<Tech>("loggedUser") == null)
                context.Result = new RedirectResult("/Home/Login");
            if (context.HttpContext.Session.GetObject<Customer>("loggedUser") == null)
                context.Result = new RedirectResult("/Home/Login");
        }
    }
}
