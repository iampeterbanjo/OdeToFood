//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using OdeToFood.Models;

//namespace OdeToFood.Controllers {
//  public class ReviewsController : Controller {
//    //
//    // GET: /Reviews/
//    // stub restaurant data
//    List<RestaurantReview> _reviews = new List<RestaurantReview>{
//      new RestaurantReview {
//        Id = 1,
//        Name = "Hot Cross Buns",
//        City = "London",
//        Rating = 10
//      },
//      new RestaurantReview {
//        Id = 2,
//        Name = "Burger Queen",
//        City = "New York",
//        Rating = 5
//      }
//    };

//    [ChildActionOnly]
//    public ActionResult BestReview() {
//      var bestReview = from r in _reviews orderby r.Rating descending select r;

//      return PartialView("_Review", bestReview.First());
//    }

//    public ActionResult Index() {

//      var model = from r in _reviews orderby r.Country select r;

//      return View(model);
//    }

//    public ActionResult Details(int id) {
//      return View();
//    }

//    public ActionResult Edit(int id) {
//      var review = _reviews.Single(r => r.Id == id);

//      return View(review);
//    }

//    [HttpPost]
//    public ActionResult Edit(int id, FormCollection collection) {
//      var review = _reviews.Single(r => r.Id == id);

//      if (TryUpdateModel(review)) {
//        return RedirectToAction("Index");
//      }
//      return View(review);
//    }
//  }
//}
