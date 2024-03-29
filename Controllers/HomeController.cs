﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers {
  public class HomeController : Controller {

    OdeToFoodDb _db = new OdeToFoodDb();

    public ActionResult Index() {
      ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

      var model = _db.Restaurants.ToList();

      return View(model);
    }

    public ActionResult About() {
      var model = new AboutModel();
      model.Name = "Peter";
      model.Location = "London";

      return View(model);
    }

    public ActionResult Contact() {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    protected override void Dispose(bool disposing) {
      if (_db != null) {
        _db.Dispose();
      }
      base.Dispose(disposing);
    }
  }
}
