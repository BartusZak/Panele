
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Panele.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Panele.Users;

namespace Panele.DAL
{
	public class ShopContext : IdentityDbContext<ApplicationUser>
	{
		public ShopContext() : base("ShopContext") { }
		public DbSet<Product> Products { get; set; }
		public DbSet<RateValue> RateValues { get; set; }

		public static ShopContext Create()
		{
			return new ShopContext();
		}
	}
}