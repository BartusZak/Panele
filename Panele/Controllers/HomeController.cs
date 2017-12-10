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

	}

}