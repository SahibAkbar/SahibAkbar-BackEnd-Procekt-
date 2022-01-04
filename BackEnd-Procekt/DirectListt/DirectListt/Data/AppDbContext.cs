using DirectListt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<KeyPeople> KeyPeoples { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantImage> RestaurantImages { get; set; }
        public DbSet<RestaurantReview> RestaurantReviews { get; set; }
        public DbSet<RestaurantToFetaure> RestaurantToFetaures { get; set; }
        public DbSet<RestaurantToMenu> RestaurantToMenus { get; set; }
        public DbSet<RestaurantToTag> RestaurantToTags { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UserAdmin> UserAdmins { get; set; }
        public DbSet<Adminstrator> Adminstrators { get; set; }
    }
}
