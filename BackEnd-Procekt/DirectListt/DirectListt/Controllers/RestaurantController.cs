using DirectListt.Data;
using DirectListt.Models;
using DirectListt.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Controllers
{
        public class RestaurantController : Controller
        {
            private readonly AppDbContext _context;

            public RestaurantController(AppDbContext context)
            {
                _context = context;
            }
        #region SearchData
        public IActionResult Index(string Searchdata)
        {
            List<Restaurant> restaurants = _context.Restaurants.Include(i => i.RestaurantImages)
                                                               .Include(t => t.RestaurantToTags).ThenInclude(tg => tg.Tag)
                                                               .Include(f => f.RestaurantToFetaures).ThenInclude(ft => ft.Feature)
                                                               .Include(m => m.RestaurantToMenus).ThenInclude(mn => mn.Menu)
                                                               .ToList();

            VmRestaurant model = new VmRestaurant();
            model.Restaurants = _context.Restaurants.ToList();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Restaurant");
            model.Restaurants = _context.Restaurants.Where(b => (Searchdata != null ? b.Name.ToLower().Contains(Searchdata.ToLower()) : true)).ToList();
            model.Restaurants = restaurants;

            return View(model);
        }
        #endregion

        public IActionResult Details(int? id)
            {
                Restaurant restaurant1 = null;
                //List<RestaurantComment> restaurantComments = _context.RestaurantComments.OrderByDescending(bc => bc.CreatedDate).Where(i => i.RestaurantId == id).ToList();
                if (id != null)
                {
                    restaurant1 = _context.Restaurants.Find(id);
                }


                Setting setting = _context.Settings.FirstOrDefault();
                List<Social> socials = _context.Socials.ToList();
                Restaurant restaurant = _context.Restaurants
                                                                .Include(ri => ri.RestaurantImages)
                                                                .Include(rt => rt.RestaurantToTags).ThenInclude(t => t.Tag)
                                                                .Include(rf => rf.RestaurantToFetaures).ThenInclude(f => f.Feature)
                                                                .Include(rm => rm.RestaurantToMenus).ThenInclude(m => m.Menu)
                                                                .Include(rr => rr.RestaurantReviews)
                                                                .Include(a => a.Adminstrators)
                                                                .FirstOrDefault(i => i.Id == id);

                VmBooking detail = new VmBooking()
                {
                    Socials = socials,
                    Setting = setting,
                    Restaurant = restaurant,
                    Banner = _context.Banners.FirstOrDefault(b => b.Page == "RestaurantDetail"),
                    RestaurantReview = _context.RestaurantReviews.FirstOrDefault()
                };

                return View(detail);
            }
            [HttpPost]
            public IActionResult Comment(VmBooking vmBookings)
            {
                Setting setting = _context.Settings.FirstOrDefault();
                List<Social> socials = _context.Socials.ToList();
                List<Restaurant> restaurants = _context.Restaurants.ToList();

                if (ModelState.IsValid)
                {
                    vmBookings.RestaurantReview.CreatedDate = DateTime.Now;
                    _context.RestaurantReviews.Add(vmBookings.RestaurantReview);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                VmBooking vmBooking = new VmBooking()
                {
                    Socials = socials,
                    Setting = setting,
                    RestaurantReview = vmBookings.RestaurantReview,
                    Restaurant = vmBookings.Restaurant,
                    Restaurants = restaurants
                };



                return View("Index", vmBooking);
            }
        }
}
