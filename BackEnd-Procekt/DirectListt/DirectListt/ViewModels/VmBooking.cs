using DirectListt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.ViewModels
{
    public class VmBooking:VmLayout
    {
        public Banner Banner { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public RestaurantReview RestaurantReview { get; set; }
    }
}
