using DirectListt.Data;
using DirectListt.Models;
using DirectListt.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccountController(AppDbContext context, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(VmRegister vmRegister)
        {
            if (ModelState.IsValid)
            {
                if (vmRegister.ImageFile != null)
                {
                    string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + vmRegister.ImageFile.FileName;
                    string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        vmRegister.ImageFile.CopyTo(stream);
                    }
                    UserAdmin newUser = new UserAdmin()
                    {
                        FullName = vmRegister.Name + " " + vmRegister.SurName,
                        CreatedDate = DateTime.Now,
                        Email = vmRegister.Email,
                        UserName = vmRegister.Email,
                        Image = fileName
                    };

                    var result = await _userManager.CreateAsync(newUser, vmRegister.Password);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(newUser, false);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                        return View(vmRegister);
                    }
                }

            }
            return View(vmRegister);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(VmRegister vmRegister)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(vmRegister.Email) || !string.IsNullOrEmpty(vmRegister.Password))
                {
                    var result = await _signInManager.PasswordSignInAsync(vmRegister.Email, vmRegister.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Username or password is not correct!!!!");
                        return View(vmRegister);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Formu doldurun");
                    return View(vmRegister);
                }

            }

            return View(vmRegister);
        }
        //public async Task<IActionResult> Logout()
        //{
        //    await _signInManager.SignOutAsync();
        //    return RedirectToAction("Login");
        //}
        public IActionResult Users()
        {
            List<UserAdmin> model = _context.UserAdmins.ToList();

            return View(model);
        }
        public IActionResult UpdateUser(string id)
        {
            UserAdmin user = _context.UserAdmins.Find(id);

            return View(user);
        }
        [HttpPost]
        public IActionResult UpdateUser(UserAdmin user)
        {
            if (ModelState.IsValid)
            {
                UserAdmin usert = _context.UserAdmins.Find(user.Id);

                usert.FullName = user.FullName;
                usert.Email = user.Email;
                _context.SaveChanges();
                return RedirectToAction("Users");
            }
            return View(user);
        }
    }
}
