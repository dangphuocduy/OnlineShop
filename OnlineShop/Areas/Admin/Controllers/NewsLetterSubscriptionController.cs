﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class NewsLetterSubscriptionController : Controller
    {
        // GET: Admin/NewsLetterSubscription
        public ActionResult Index()
        {
            return View();
        }
    }
}