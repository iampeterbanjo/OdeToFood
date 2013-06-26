using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers {
  public class CuisineController : Controller {
    
    // [Authorize]
    [Log]
    public ActionResult Search(string name = "french") {

      var message = Server.HtmlEncode(name);
      // return RedirectToAction("Index", "Home", new { name = name });

      return Content(message);
      // return File(Server.MapPath("~/Content/site.css"), "text/css");
      // return Json(new { Message = message, name = "Peter" }, JsonRequestBehavior.AllowGet);
    }
  }
}