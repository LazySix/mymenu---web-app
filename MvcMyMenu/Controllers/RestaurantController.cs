using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMyMenu.Models;

namespace MvcMyMenu.Controllers
{
    public class RestaurantController : Controller
    {
       private MyMenuEntities storeDb = new MyMenuEntities();
        //
        // GET: /Restaurant/

        public ActionResult Index()
        {
            var restaurants = storeDb.Restaurants.ToList();
        
            return View(restaurants);
            
        }

        public ActionResult Browse(string restaurant)
        {
            var restaurantModel = storeDb.Restaurants.Include("Menus").Single(r => r.Name == restaurant);
                    
            return View(restaurantModel);
        }

        public ActionResult Details(int id)
        {
            var menus = storeDb.Menus.Find(id);
            return View(menus);
        }

    }
}
