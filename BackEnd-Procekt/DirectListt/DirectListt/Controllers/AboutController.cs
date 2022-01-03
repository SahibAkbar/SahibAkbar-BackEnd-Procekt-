using DirectListt.Data;
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
            VmAbout model = new VmAbout();
            model.About = _context.Abouts.FirstOrDefault();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Banner = _context.Banners.FirstOrDefault(c => c.Page == "About");
            return View(model);
        }
    }
}
