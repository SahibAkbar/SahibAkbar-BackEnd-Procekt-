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
    public class BlogController : Controller
    {
        

        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string Searchdata)
        {
            VmBlog model = new VmBlog();
            model.Blogs = _context.Blogs.ToList();
            model.CustomUser = _context.CustomUsers.FirstOrDefault();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Socials = _context.Socials.ToList();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Blogs");
            model.Blogs = _context.Blogs.Where(b => (Searchdata != null ? b.Name.ToLower().Contains(Searchdata.ToLower()) : true)).ToList();
            return View(model);
        }
        public IActionResult Detail(int? id)
        {
            Blog blog = null;
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            Banner banner = _context.Banners.FirstOrDefault(b => b.Page == "Detail");
            List<Comment> comments = _context.Comments.OrderByDescending(bc => bc.CretedDate).Where(i => i.BlogId == id).ToList();
            CustomUser customuser = _context.CustomUsers.FirstOrDefault();
            if (id != null)
            {
                blog = _context.Blogs.Find(id);
            }

            VmBlog vmBlog = new VmBlog()
            {
                Socials = socials,
                Setting = setting,
                Blog = blog,
                Comments = comments,
                Banner = banner,
                CustomUser = customuser
            };
            return View(vmBlog);
        }

        [HttpPost]
        public IActionResult Comment(VmBlog vmBlog)
        {
            Setting setting = _context.Settings.FirstOrDefault();
            List<Social> socials = _context.Socials.ToList();
            List<Blog> blogs = _context.Blogs.ToList();

            if (ModelState.IsValid)
            {
                vmBlog.Comment.CretedDate = DateTime.Now;
                _context.Comments.Add(vmBlog.Comment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            VmBlog vmBlogt = new VmBlog()
            {
                Socials = socials,
                Setting = setting,
                Comment = vmBlog.Comment,
                Blog = vmBlog.Blog,
                Blogs = blogs
            };



            return View("Index", vmBlogt);
        }


    }
}
