using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
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


        [Required]
        [StringLength(50)]
        [Display(Name="Nazwa")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Firma")]
        public string Company { get; set; }

        [Required]
        [Display(Name = "Cena")]
        public double Cost { get; set; }

        [Required]
        [Display(Name = "Data dodania")]
        public DateTime AddDate { get; set; }

        [Required]
        [Display(Name = "Stan")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Rodzaj")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Ocena")]
        public double Rate { get; set; }

        [Required]
        [Display(Name = "Szerokość")]
        public double Width { get; set; }

        [Required]
        [Display(Name = "Długość")]
        public double Lenght { get; set; }

        [Required]
        [Display(Name = "Wysokość")]
        public double Height { get; set; }

        [Required]
        [Display(Name = "Waga")]
        public double Weight { get; set; }

        [Required]
        [Display(Name = "Głębokość")]
        public double Greg { get; set; } // Glebokosc

        [Required]
        [Display(Name = "Kolor")]
        public string Color { get; set; }

        [Required]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Materiał")]
        public string Material { get; set; }
    }
}