using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Customers_Portal.Models;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Customers_Portal.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
                              SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
           // ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(requestUri:$"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Customers/{model.Email}");

            dynamic res = await response.Content.ReadAsAsync<JObject>();
            string prompt = res.dialog.prompt.ToString();

            if (ModelState.IsValid && response.StatusCode ==HttpStatusCode.OK && response.Content.Headers.ContentLength>2)
            {
                var user = new IdentityUser 
                {
                    UserName = model.Email,
                    Email = model.Email,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {

            //var branch = new Branch
            //{
            //    branchName = "Regie",
            //    address = "Naval"

            //};
            //branchContext.Branch.Add(branch);
            //branchContext.SaveChanges();

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
               var responseGet = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Customers/email/{user.Email}");

           // var responseGet = await httpClient.GetAsync(requestUri: $"https://localhost:5001/api/Customers/email/{user.Email}");

            List<UesrModel> res = await responseGet.Content.ReadAsAsync < List<UesrModel>> ();

            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home", new { id= res[0].id });
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(user);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}
