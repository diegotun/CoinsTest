using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinsTest.Models
{
    public interface IItemsRepository
    {
        CoinDetails.RootElement GetDetails(string Id);

        string GetJSONString();

        string GetJSONDetails();

        IEnumerable<Items> GetAllItems();

        Items Add(Items items);
    }
}
