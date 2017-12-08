using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Panele.DAL;
using System.Net;
using Panele.Models;
using PagedList;
using Panele.ViewModels;

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
		public ActionResult Index(int? page,string CurrentFilter,string searchString)
		{
            ViewBag.currentFilter = searchString;
            var productList = from p in _context.Products
                              select p;

            if (searchString != null)
            {
                page = 1;
            }
            if (!String.IsNullOrEmpty(searchString))
            {
                productList = productList.Where(p => p.Name.Contains(searchString));
            }

            productList = productList.OrderBy(x => x.Name);
            int pageSize = 20;
            int numberPage = (page ?? 1);
			return View(productList.ToPagedList(numberPage,pageSize));
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
            selectedProduct.numberOfVotes++;
            _context.SaveChanges();

            var RateValues = _context.RateValues.ToList();
            bool check = _context.RateValues.Any(x => x.ProductId == id);
            InformationAboutVotesViewModel Infos = new InformationAboutVotesViewModel();
            Infos.yourRate = voteRate;
            Infos.numberOfVotes = selectedProduct.numberOfVotes;

            if (check == false)
            {
                RateValue NewAdded = new RateValue();
                NewAdded.ProductId = id;
                switch (voteRate)
                {
                    case 1:
                        NewAdded.RateNumberOne++;
                        break;
                    case 2:
                        NewAdded.RateNumberTwo++;
                        break;
                    case 3:
                        NewAdded.RateNumberThree++;
                        break;
                    case 4:
                        NewAdded.RateNumberFour++;
                        break;
                    case 5:
                        NewAdded.RateNumberFive++;
                        break;
                }
                _context.RateValues.Add(NewAdded);
                selectedProduct.Rate = RateChanger(selectedProduct.numberOfVotes, NewAdded.RateNumberOne, NewAdded.RateNumberTwo, NewAdded.RateNumberThree, NewAdded.RateNumberFour, NewAdded.RateNumberFive);
                _context.SaveChanges();
                Infos.actualRate = Math.Round(selectedProduct.Rate, 2);
            }
            if (check == true)
            {
                var FindFrom = _context.RateValues.Single(x => x.ProductId == id);
                switch (voteRate)
                {
                    case 1:
                        FindFrom.RateNumberOne++;
                        break;
                    case 2:
                        FindFrom.RateNumberTwo++;
                        break;
                    case 3:
                        FindFrom.RateNumberThree++;
                        break;
                    case 4:
                        FindFrom.RateNumberFour++;
                        break;
                    case 5:
                        FindFrom.RateNumberFive++;
                        break;
                }
                selectedProduct.Rate = RateChanger(selectedProduct.numberOfVotes, FindFrom.RateNumberOne, FindFrom.RateNumberTwo, FindFrom.RateNumberThree, FindFrom.RateNumberFour, FindFrom.RateNumberFive);
                _context.SaveChanges();
                Infos.actualRate = Math.Round(selectedProduct.Rate, 2);
            }
            
            return View(Infos);
        }
        private double RateChanger(int numberOfVotes, double R1, double R2, double R3, double R4, double R5)
        {
            return Convert.ToDouble(((1*R1)+(2*R2)+(3*R3)+(4*R4)+(5*R5))/numberOfVotes);
        }
	}
}