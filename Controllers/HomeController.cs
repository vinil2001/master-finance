﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Finance.Models; 

namespace Finance.Controllers
{

    [Authorize]  

    public class HomeController : Controller
    {

        ApplicationDbContext Db = new ApplicationDbContext();

         
        public ActionResult Index()
        {
            Debug.Log("Entering to home page");
            if (!User.IsInRole("Developer") && !User.IsInRole("User"))
                return RedirectToAction("Index", "PaymentStatements");
        
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

   
        public ActionResult MenuBar()
        {
            return PartialView();
        }
    }
}