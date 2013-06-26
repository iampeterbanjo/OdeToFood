namespace OdeToFood.Migrations {
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;
  using OdeToFood.Models;
  using System.Collections.Generic;

  internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb> {
    public Configuration() {
      AutomaticMigrationsEnabled = true;
    }

    protected override void Seed(OdeToFood.Models.OdeToFoodDb context) {

      context.Restaurants.AddOrUpdate(r => r.Name,
        new Restaurant { Name = "Hog's breath", City = "Brisbane", Country = "Australia" },
        new Restaurant { Name = "Sizzler", City = "Brisbane", Country = "Australia" },
        new Restaurant { Name = "Pizza Hut", City = "High Wycombe", Country = "United Kingdom", 
          Reviews = new List<RestaurantReview> { new RestaurantReview { Rating = 3, Body = "Bad food", ReviewerName = "Abraham" } } }
      );
    }
  }
}
