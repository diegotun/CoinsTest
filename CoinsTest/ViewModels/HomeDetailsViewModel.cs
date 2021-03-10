using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoinsTest.Models;

namespace CoinsTest.ViewModels
{
    public class HomeDetailsViewModel
    {
        
        public CoinDetails.RootElement coinDetails { get; set; }
        public string PageTitle { get; set; }
    }
}
