using Blog.Interfaces;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostPresentationService service;

        public HomeController(IPostPresentationService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {            
            return View(service.GetItems(10));
        }

    }
}
