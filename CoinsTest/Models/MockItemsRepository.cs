using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CoinsTest.Models
{
    public class MockItemsRepository : IItemsRepository
    {
        private List<Items> _itemsList;
        private IConfiguration _config;
        private string _jsonAllItems;
        private string _jsonDetails;
        

        public MockItemsRepository(IConfiguration config)
        {
            _config = config;
            string json = new WebClient().DownloadString(_config["APIURL"] + "list");
            _jsonAllItems = json;

            _itemsList = JsonConvert.DeserializeObject<List<Items>>(json);
        }

        public Items Add(Items item)
        {
            item.Id = _itemsList.Max(e => e.Id) + 1;
            _itemsList.Add(item);
            int total = _itemsList.Count();
            return item;
        }

        public string GetJSONString()
        {
            return _jsonAllItems;
        }

        public IEnumerable<Items> GetAllItems()
        {
            return _itemsList;
        }

        public CoinDetails.RootElement GetDetails(string Id)
        {
            
            string str_params = "?tickers=false&market_data=false&community_data=false&developer_data=false&sparkline=false";
   
            string json = new WebClient().DownloadString(_config["APIURL"] + Id + str_params);
            _jsonDetails = json;

            var model = JsonConvert.DeserializeObject<CoinDetails.RootElement>(json);
            return model;
        }

        public string GetJSONDetails()
        {
            return _jsonDetails;
        }
    }
}
