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
		public ActionResult Index()
		{
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
		public ViewResult Register(RegisterViewModel model)
		{
			if(ModelState.IsValid)
			{
			}
			return View();
		}
	}

}