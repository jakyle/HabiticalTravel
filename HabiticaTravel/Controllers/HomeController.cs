﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HabiticaTravel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                //send them to the AuthenticatedIndex page instead of the index page
                return View();
            }
            return View("../Home/NotAuthorized", "../Shared/_NotAuthorized");
        }
    }
}