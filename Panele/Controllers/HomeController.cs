using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Panele.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Panele.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index(bool? afterSuccessfulRegister)
		{
			if(afterSuccessfulRegister == true) //musi byc == true bo typ nullowalny
				ViewBag.justRegistered = "<script>alert('Pomyślnie zarejestrowano.')</script>";
			return View();
		}

		public ViewResult About()
		{
			return View();
		}
		public ViewResult Kadra()
		{
			return View();
		}

		public ViewResult Contact()
		{
			return View();
		}

		public ViewResult Ofert()
		{
			return View();
		}
		[HttpGet]
		public ViewResult LogIn(string returnUrl)
		{
			ViewBag.returnUrl = returnUrl;
			return View();
		}
		[HttpPost]
		public ActionResult LogIn(LogInViewModel model)
		{
			if (ModelState.IsValid)
			{
			}
			return View();
		}
		[HttpGet]
		public ViewResult Register()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Register(RegisterViewModel model)
		{
			if (ModelState.IsValid)
			{
				ApplicationUser user;
				ApplicationUserStore store = new ApplicationUserStore(new DAL.ShopContext());
				ApplicationUserManager userManager = new ApplicationUserManager(store);
				user = new ApplicationUser { UserName = model.UserName };
				var result = userManager.Create(user, model.Password);
				if (result.Succeeded)
					return RedirectToAction("Index", "Home", new { afterSuccessfulRegister = true});
				AddErrors(result);
			}
			return View(model);
		}
		private void AddErrors(IdentityResult result)
		{
			foreach (var error in result.Errors)
				ModelState.AddModelError("", error);
		}
	}

}