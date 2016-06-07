﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NoRegretsWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Your Event page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your Contact page.";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Your Products page.";

            return View();
        }
        public ActionResult FreedomNetwork()
        {
            ViewBag.Message = "Your Freedom Network page.";

            return View();
        }
    }
}