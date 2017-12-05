using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Panele.Models;

namespace Panele.ViewModels
{
    public class SendingLastAddedRecordsViewModel
    {
        public IEnumerable<Product> AddedyesterdayList { get; set; }
        public IEnumerable<Product> AddedMonthBefore { get; set; }
       

    }
}