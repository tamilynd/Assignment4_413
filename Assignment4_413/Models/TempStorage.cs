using System.Collections.Generic;

namespace Assignment4_413.Models
{
    public class TempStorage
    {
        //Create tempstorage list
        private static List<Restaurant> restaurants = new List<Restaurant>();
        public static IEnumerable<Restaurant> Restaurants => restaurants;

        
        //Function to add restaurants to list
        public static void AddRestaurant(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
        }

    }
}
