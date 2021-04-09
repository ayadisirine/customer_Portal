using Customers_Portal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Customers_Portal.Controllers
{
    public class ProductController
    {
            private readonly ILogger<ProductController> _logger;
            public dynamic user;


            public ProductController(ILogger<ProductController> logger)
            {
                _logger = logger;
            }

            public async Task<IActionResult> Products(long id)
            {
                  var httpClient = new HttpClient();
                  httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                  var responseGet = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Buildings/id/{id}");
                  //string response = await responseGet.Content.ReadAsStringAsync();

                 // List<UesrModel> res = await responseGet.Content.ReadAsAsync<List<UesrModel>>();

                //  ViewData["username"] = res[0].companyName ;

               // ViewData["username"] = "58";
                return View();
            }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }

        public IActionResult Privacy()
            {
                return View();
            }

        /*
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }

 }