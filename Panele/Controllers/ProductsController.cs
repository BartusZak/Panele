using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Panele.DAL;
using System.Net;

namespace Panele.Controllers
{
	public class ProductsController : Controller
	{
		// GET: Products
		private ShopContext _context;
		public ProductsController()
		{
			_context = new ShopContext();
		}
		public ActionResult Index()
		{
			var products = _context.Products.ToList();
			return View(products);
		}
		public ActionResult Details(int? Id)
		{
			var product = _context.Products.SingleOrDefault(x => x.Id == Id);
			if (Id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			if (product == null)
			{
				return HttpNotFound();
			}
			return View(product);
		}
	}
}