using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoinsTest.Models
{
    public class Coin
    {
        public int Id { get; set; }

        public string Symbol { get; set; }

        public string Name { get; set; }

    }
}