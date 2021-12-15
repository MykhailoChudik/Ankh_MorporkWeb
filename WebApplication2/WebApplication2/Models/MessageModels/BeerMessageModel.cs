using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.MessageModels
{
    public class BeerMessageModel
    {
        public int Number { get; set; }
        public int CostDollar { get; set; }
        public int PlayerDollar { get; set; }
        public int PlayerPenny { get; set; }
    }
}