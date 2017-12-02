using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panele.Models
{

    public class Product
    {
        public Product() { }
        public Product(int Id, string Name, string Company, double Cost, DateTime AddDate, string State,string Type,double Rate,double Width,double Length,double Height,double Weight, double Greg,string Color,string Description,string Material)
        {
            this.Id = Id;
            this.Name = Name;
            this.Company = Company;
            this.Cost = Cost;
            this.AddDate = AddDate;
            this.State = State;
            this.Type = Type;
            this.Rate = Rate;
            this.Width = Width;
            this.Lenght = Length;
            this.Height = Height;
            this.Weight = Weight;
            this.Greg = Greg;
            this.Color = Color;
            this.Description = Description;
            this.Material = Material;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public double Cost { get; set; }
        public DateTime AddDate { get; set; }
        public string State { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }
        public double Width { get; set; }
        public double Lenght { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Greg { get; set; } // Glebokosc
        public string Color { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
    }
}