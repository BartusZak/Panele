using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Panele.Models;

namespace Panele.ViewModels
{
    public class InformationAboutVotesViewModel
    {
        public double oldRate { get; set; }
        public double actualRate { get; set; }
        public int numberOfVotes { get; set; }
        public int yourRate { get; set; }
    }
}