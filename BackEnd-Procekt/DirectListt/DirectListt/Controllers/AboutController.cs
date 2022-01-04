using DirectListt.Data;
using DirectListt.Models;
using DirectListt.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            About about = _context.Abouts.FirstOrDefault();
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            Banner banner = _context.Banners.FirstOrDefault(b => b.Page.ToLower() == "about");
            VmAbout vmAbout = new VmAbout()
            {
                Setting = setting,
                Socials = socials,
                About = about,
                Banner = banner
            };
            return View(vmAbout);
   
        }
    }
}
