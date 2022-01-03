using DirectListt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.ViewModels
{
    public class VmRetaurant:VmLayout
    {
        public List<Restaurant> Restaurants { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<Feature> Features { get; set; }
        public List<KeyPeople> KeyPeoples { get; set; }
        public List<Menu> Menus { get; set; }
        public List<RestaurantReview> RestaurantReviews { get; set; }
        public List<Tag> Tags { get; set; }
        public Banner Banner { get; set; }
    }
}
