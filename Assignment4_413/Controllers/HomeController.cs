using Assignment4_413.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_413.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //create string
            List<string> RestaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string favDish = r.FavoriteDish ?? "It's all tasty!";
                RestaurantList.Add($"#{r.Rank}: {r.RestaurantName} -- {favDish} ||| Address: {r.Address} -- Phone: {r.PhoneNumber} -- Website: {r.LinkToSite} ");
            }

            //pass string array to the view
            return View(RestaurantList);
        }


        [HttpGet]
        public IActionResult SuggestionForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SuggestionForm(Restaurant restaurant)
        {
            //Check for model validity
            if (ModelState.IsValid)
            {
                //add restaurant to suggestion list
                TempStorage.AddRestaurant(restaurant);
                //return view
                return View("ThankYou", restaurant);
            }

            //if model is not valid do not switch views, and do not add restaurant
            else
            {
                return View();
            }
        }

        public IActionResult SuggestionList()
        {
            //pass in pre-determined restaurants
            return View(TempStorage.Restaurants);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
