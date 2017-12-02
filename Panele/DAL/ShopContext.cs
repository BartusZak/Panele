
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Panele.Models;
using System.Data.Entity;

namespace Panele.DAL
{
    public class ShopContext:DbContext
    {
        public ShopContext() : base("ShopContext") { }
        public DbSet<Product> Products { get; set; }
    }
}