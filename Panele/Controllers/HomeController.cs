﻿using System;
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
		public ViewResult LogIn()
		{
			return View();
		}
	}

}