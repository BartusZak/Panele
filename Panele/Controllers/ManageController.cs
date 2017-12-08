using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Panele.Models;
using Panele.DAL;
using System.Data.Entity;
using System.Net;
using System.Data;
using PagedList;
using Panele.ViewModels;

namespace Panele.Controllers
{
    public class ManageController : Controller
    {
        // GET: Manage
        private ShopContext _context;
        public ManageController()
        {
            _context = new ShopContext();
        }
     
        public ActionResult Index(string sortBy, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortBy;
            ViewBag.byName = String.IsNullOrEmpty(sortBy) ? "name" : "";
            ViewBag.byCompany = String.IsNullOrEmpty(sortBy) ? "comp" : "";
            ViewBag.byCost = sortBy == "High" ? "high" : "High";
            ViewBag.byDate = sortBy == "Date" ? "date" : "Date";
            ViewBag.byState = sortBy == "State" ? "state" : "State";
            ViewBag.byType = sortBy == "Type" ? "type" : "Type";
            ViewBag.byMaterial = sortBy == "Material" ? "material" : "Material";

            if(searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;
            var productList = from p in _context.Products
                           select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                productList = productList.Where(p => p.Id.ToString().Contains(searchString)
                || p.Name.Contains(searchString) || p.State.Contains(searchString) || p.Material.Contains(searchString));
            }
            switch (sortBy)
            {
                case "name":
                    productList = productList.OrderByDescending(p => p.Name);
                    break;
                case "comp":
                    productList = productList.OrderByDescending(p => p.Company);
                    break;
                case "High":
                    productList = productList.OrderBy(p => p.Cost);
                    break;
                case "high":
                    productList = productList.OrderByDescending(p => p.Cost);
                    break;
                case "Date":
                    productList = productList.OrderBy(p => p.AddDate);
                    break;
                case "date":
                    productList = productList.OrderByDescending(p => p.AddDate);
                    break;
                case "State":
                    productList = productList.OrderByDescending(p => p.State);
                    break;
                case "state":
                    productList = productList.OrderBy(p => p.State);
                    break;
                case "Type":
                    productList = productList.OrderByDescending(p => p.Type);
                    break;
                case "type":
                    productList = productList.OrderBy(p => p.Type);
                    break;
                case "Material":
                    productList = productList.OrderByDescending(p => p.Material);
                    break;
                case "material":
                    productList = productList.OrderBy(p => p.Material);
                    break;
                default:
                    productList = productList.OrderBy(p => p.Id);
                    break;
            }
            int pageSize = 15;
            int numberPage = (page ?? 1);
            return View(productList.ToPagedList(numberPage, pageSize));
            
        }
       
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = _context.Products.Find(id);
            if(product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                var valProduct = new Product();
                valProduct = product;
                return View("AddProduct", product);
            }
            var UpdateTime = DateTime.Now;
            product.AddDate = UpdateTime;
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index","Manage");
        }
       
    
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = _context.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Product product)
        {
            if (!ModelState.IsValid)
            {
                var valProduct = new Product();
                valProduct = product;
                return View("Edit", product);
            }
            var UpdateTime = DateTime.Now;
            var productionDB = _context.Products.Single(x => x.Id == product.Id);
            var voteNumers = productionDB.numberOfVotes;
            var actualRate = productionDB.Rate;
            productionDB.numberOfVotes = voteNumers;
            productionDB.Rate = actualRate;
            productionDB.Category = product.Category;
            productionDB.Model = product.Model;
            productionDB.Name = product.Name;
            productionDB.Company = product.Company;
            productionDB.Cost = product.Cost;
            productionDB.AddDate = UpdateTime;
            productionDB.State = product.State;
            productionDB.Type = product.Type;
            productionDB.Width = product.Width;
            productionDB.Lenght = product.Lenght;
            productionDB.Height = product.Height;
            productionDB.Weight = product.Weight;
            productionDB.Greg = product.Greg;
            productionDB.Color = product.Color;
            productionDB.Description = product.Description;
            productionDB.Material = product.Material;
            _context.SaveChanges();
            return RedirectToAction("Index", "Manage");
        }

        public ActionResult Delete(int Id)
        {
                var ProductinDb = _context.Products.Find(Id);
                _context.Products.Remove(ProductinDb);
                _context.SaveChanges();
            return RedirectToAction("Index", "Manage");
        }
        public ActionResult LastAdd(string sortBy, string searchString, int? showDataType)
        {


            ViewBag.dataType = showDataType;
            ViewBag.byName = String.IsNullOrEmpty(sortBy) ? "name" : "";
            ViewBag.byCompany = String.IsNullOrEmpty(sortBy) ? "comp" : "";
            ViewBag.byCost = sortBy == "High" ? "high" : "High";
            ViewBag.byDate = sortBy == "Date" ? "date" : "Date";
            ViewBag.byState = sortBy == "State" ? "state" : "State";
            ViewBag.byType = sortBy == "Type" ? "type" : "Type";
            ViewBag.byMaterial = sortBy == "Material" ? "material" : "Material";


           


            var viewModel = new SendingLastAddedRecordsViewModel();
           
         

          
            var productList = from p in _context.Products
                              select p;
            


            switch (sortBy)
            {
                case "name":
                    productList = productList.OrderByDescending(p => p.Name);
                    break;
                case "comp":
                    productList = productList.OrderByDescending(p => p.Company);
                    break;
                case "High":
                    productList = productList.OrderBy(p => p.Cost);
                    break;
                case "high":
                    productList = productList.OrderByDescending(p => p.Cost);
                    break;
                case "Date":
                    productList = productList.OrderBy(p => p.AddDate);
                    break;
                case "date":
                    productList = productList.OrderByDescending(p => p.AddDate);
                    break;
                case "State":
                    productList = productList.OrderByDescending(p => p.State);
                    break;
                case "state":
                    productList = productList.OrderBy(p => p.State);
                    break;
                case "Type":
                    productList = productList.OrderByDescending(p => p.Type);
                    break;
                case "type":
                    productList = productList.OrderBy(p => p.Type);
                    break;
                case "Material":
                    productList = productList.OrderByDescending(p => p.Material);
                    break;
                case "material":
                    productList = productList.OrderBy(p => p.Material);
                    break;
                default:
                    productList = productList.OrderByDescending(p => p.AddDate);
                    break;
            }




            //productList = productList.Where(p => p.Id.ToString().Contains(searchString)
            // || p.Name.Contains(searchString) || p.State.Contains(searchString) || p.Material.Contains(searchString));
            if (productList != null)
            {
                productList = productList.Where(p => p.AddDate.Month == DateTime.Now.Month & p.AddDate.Year == DateTime.Now.Year);
                viewModel.AddedMonthBefore = productList;

                


                productList = productList.Where(p => p.AddDate.Day == DateTime.Now.Day & p.AddDate.Month == DateTime.Now.Month && p.AddDate.Year == DateTime.Now.Year);
                viewModel.AddedyesterdayList = productList;

               
                
            }
           
            return View(viewModel);
        }

        public ActionResult LastFromDb()
        {
            var product = _context.Products.ToList();
            var last = product.Last();

            return RedirectToAction("Details", new { id = product.Last().Id });
        }




    } 
}