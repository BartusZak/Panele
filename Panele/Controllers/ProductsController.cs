using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Panele.DAL;
using System.Net;
using Panele.Models;

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
        public ActionResult ChangeRate(int id, int voteRate)
        {
          
            var selectedProduct = _context.Products.Find(id);
            var RateValues = _context.RateValues.ToList();
            bool check = _context.RateValues.Any(x => x.Id == id);

            ViewBag.data = check.ToString();




            

          
            return View();
        }
        private double RateChanger(int numberOfVotes, int UserVote, double R1, double R2, double R3, double R4, double R5)
        {
            if(numberOfVotes == 0)
            {
                return 0;
            }
            return Convert.ToDouble(((1*R1)+(2*R2)+(3*R3)+(4*R4)+(5*R5))/numberOfVotes);
        }
	}
}