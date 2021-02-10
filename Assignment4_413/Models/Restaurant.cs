using System.ComponentModel.DataAnnotations;

namespace Assignment4_413.Models
{
    public class Restaurant
    {

        //constructor needed to set readonly rank
        public Restaurant(int rank)
        {
            Rank = rank;
        }

        //constructor needed to add rankless restaurants
        public Restaurant() 
        {
            Rank = null;
        }

        public string Name { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        public string? FavoriteDish { get; set; } = null;

        //Regular expression to determine if the phone number is in the right format
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}")]
        public string PhoneNumber { get; set; }

        [Required]
        public int? Rank { get; } = null;
        
        [Required]
        public string Address { get; set; }

        //Automatically assigns LinkToSite to be "Coming Soon"
        public string LinkToSite { get; set; } = "Coming Soon.";


        //Creates the pre-determined top 5 restaurants and returns them in a list
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Costa Vida",
                Address = "123 Prank Sinatra Drive",
                LinkToSite = "www.fun.com",
                PhoneNumber = "123-456-7890",
                FavoriteDish = "Sweet Pork Burrito"
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Dominos",
                Address = "345 Delicious Lane",
                LinkToSite = "www.pizza.com",
                PhoneNumber = "123-456-7890",
                FavoriteDish = "7.99 Large 3-topping Carryout"
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Chom",
                Address = "678 Burger Expressway",
                LinkToSite = "www.expensive.com",
                PhoneNumber = "123-456-7890"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Don Chuys",
                Address = "123 Mexico Court",
                LinkToSite = "www.burrito.com",
                PhoneNumber = "123-456-7890",
                FavoriteDish = "Breakfast Burrito"
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Sonic",
                Address = "8907 N Stake Streeet",
                PhoneNumber = "123-456-7890",
                FavoriteDish = "Strawberry Limeade"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
