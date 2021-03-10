using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoinsTest.Models;
using CoinsTest.ViewModels;
using CoinsTest.Utils;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using JsonFlatten;
using System.Data;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace CoinsTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemsRepository _itemsRepository;
        
        public HomeController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        public ViewResult Index()
        {
            var model = _itemsRepository.GetAllItems();
            return View(model);
        }
        
        [HttpGet]
        public virtual FileResult DownloadAll() 
        {
            HttpResponseMessage file = new HttpResponseMessage();
            var jsonstring = _itemsRepository.GetJSONString();
            string csv = Tools.JsonToCSV(jsonstring, ",");
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content = new StringContent(csv);
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("text/csv");
            result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = "coin_list.csv" };
            file = result;
            return File(file.Content.ReadAsByteArrayAsync().Result, "application/octet-stream", "coin_list.csv");
            
        }

        [HttpGet]
        public virtual FileResult DownloadDetails()
        {
            HttpResponseMessage file = new HttpResponseMessage();

            var jsonstring = _itemsRepository.GetJSONDetails();

            string jsonFlat = Tools.FlatAndFormatJSON(jsonstring);

            RootCoinDetails myDeserializedClass = JsonConvert.DeserializeObject<RootCoinDetails>(jsonFlat);

            string csv = Tools.ObjToCsv(myDeserializedClass);
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content = new StringContent(csv);
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("text/csv");
            result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = "coin_details.csv" };
            file = result;

            return File(file.Content.ReadAsByteArrayAsync().Result, "application/octet-stream", "coin_details.csv");
        }

        public ViewResult Details(string? id)
        {
            CoinDetails.RootElement coinDetailsList = _itemsRepository.GetDetails(id ?? "01coin");
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                coinDetails = coinDetailsList,
                PageTitle = "Coin Details"
            };

            return View(homeDetailsViewModel);
        }
    }
}
