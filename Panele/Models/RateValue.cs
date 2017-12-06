using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Panele.Models;
using System.ComponentModel.DataAnnotations;

namespace Panele.Models
{
    public class RateValue
    {
        public int Id { get; set; }

        [Display(Name = "Ocena o wartości 1")]
        public int RateNumberOne { get; set; }

        [Display(Name = "Ocena o wartości 2")]
        public int RateNumberTwo { get; set; }

        [Display(Name = "Ocena o wartości 3")]
        public int RateNumberThree { get; set; }

        [Display(Name = "Ocena o wartości 4")]
        public int RateNumberFour { get; set; }

        [Display(Name = "Ocena o wartości 5")]
        public int RateNumberFive { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public RateValue() { }
        public RateValue(int Id, int Rate1, int Rate2, int Rate3, int Rate4, int Rate5, int ProductId)
        {
            this.Id = Id;
            this.RateNumberOne = Rate1;
            this.RateNumberTwo = Rate2;
            this.RateNumberThree = Rate3;
            this.RateNumberFour = Rate4;
            this.RateNumberFive = Rate5;
            this.ProductId = ProductId;
        }

    }    
}