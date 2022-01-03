using DirectListt.Data;
using DirectListt.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmContact model = new VmContact();
            {
                model.Setting = _context.Settings.FirstOrDefault();
                model.Socials = _context.Socials.ToList();
                model.Banner = _context.Banners.FirstOrDefault(c => c.Page == "Contact");

                return View(model);
            }
        }
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(VmContact model)
        {
            if (ModelState.IsValid)
            {
                model.Contact.CretedDate = DateTime.Now;
                _context.Contacts.Add(model.Contact);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            VmContact models = new VmContact()
            {
                Setting = _context.Settings.FirstOrDefault(),
                Socials = _context.Socials.ToList(),
                Banner = _context.Banners.FirstOrDefault(b => b.Page.ToLower() == "contact")
            };
            return View("Index", models);
        }
    }
}
