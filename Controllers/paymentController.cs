﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecommerceG3.Controllers
{
    public class paymentController : Controller
    {
        // GET: payment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult proceed()
        {
            return View();
        }
    }
}