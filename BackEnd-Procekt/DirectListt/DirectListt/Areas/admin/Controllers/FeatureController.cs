using DirectListt.Data;
using DirectListt.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Areas.admin.Controllers
{
    [Area("admin")]
    public class FeatureController : Controller
    {
        private readonly AppDbContext _context;

        public FeatureController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Feature> model = _context.Features.ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Feature model)
        {
            if (ModelState.IsValid)
            {
                _context.Features.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);

        }
        public IActionResult Update(int id)
        {
            return View(_context.Features.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Feature model)
        {
                if (ModelState.IsValid)
                {
                    _context.Features.Update(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Feature feature = _context.Features.Find(id);
            _context.Features.Remove(feature);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
