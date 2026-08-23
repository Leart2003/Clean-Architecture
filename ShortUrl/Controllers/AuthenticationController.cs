using Microsoft.AspNetCore.Mvc;
using ShortUrl.Data.ViewModel;
using DbMenagment;
using Microsoft.EntityFrameworkCore;
using DbMenagment.Interfaces;
using Microsoft.AspNetCore.Identity;
using DbMenagment.Models;
using Shortly.Redirect.Helpers.Roles;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics.Eventing.Reader;

namespace ShortUrl.Controllers
{
    public class Authentication : Controller
    {
        private IUserInterface _userService;
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManger;
        private IConfiguration _configuration;

        public Authentication(IUserInterface userService, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IConfiguration configuration)
        {
            _userService = userService;
            _signInManager = signInManager;
            _userManger = userManager;
            _configuration = configuration;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Users()
        {
            var users = await _userService.GetUsersAsync();
            return View(users);
        }

        public async Task<IActionResult> Login()
        {

            return View(new LoginVm());
        }
        

        public async Task<IActionResult> Register()
        {
            return View(new RegisterVM());
        }


     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser(RegisterVM registerVM)
        {

            if (!ModelState.IsValid)
            {
                return View("Register", registerVM);
            }

            var user = await _userManger.FindByEmailAsync(registerVM.emailAdress);
            if (user != null)
            {
                ModelState.AddModelError("", "User already exists!");

                return View("Register", registerVM);
            }


            var newUser = new AppUser()
            {
                Email = registerVM.emailAdress,
                UserName = registerVM.emailAdress,
                FullName = registerVM.fullName,
                LockoutEnabled = true
            };
            var userCreate = await _userManger.CreateAsync(newUser, registerVM.password);
            if (userCreate.Succeeded)
            {
                await _userManger.AddToRoleAsync(newUser, Role.User);
                await _signInManager.PasswordSignInAsync(newUser, registerVM.password, false, false);
            }
            else
            {
                foreach (var item in userCreate.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                    return View("Register", registerVM);
                }
            }
            return RedirectToAction("Index", "Home");

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
     

       


    }
}
