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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public dynamic user;
        public string iduser ;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string id)
        {
            /*    var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseGet = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Customers/id/{id}");
                //string response = await responseGet.Content.ReadAsStringAsync();

                List<UesrModel> res = await responseGet.Content.ReadAsAsync<List<UesrModel>>();

                ViewData["username"] = res[0].companyName ;*/

            this.iduser = id;
            ViewData["id"] = id;
            return View();
        }

        public async Task<IActionResult> Products(long id)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseGet = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Buildings/customer/{id}");
            List<BuildingModel> res = await responseGet.Content.ReadAsAsync<List<BuildingModel>>();

           
            for (int i = 0; i < res.Count; i++)
            {
                // ViewBag.BuildingTable += $" <br/><br/> <table border=1 width=400 height=500>";
                //      ViewBag.BuildingTable += $"<table border=1 width=400 height=500 style=color:red, 'font-family:\"Courier New\", Courier, monospace; font-size:80%'><tr> <td value='{res[i].id}' />  <td value='{res[i].addressBuilding}' />  <td value='{res[i].fullNameAdministrator}' /> </tr></table>";
                // ViewBag.BuildingTable += $"<tr> <td value='{res[i].id}' />  <td value='{res[i].addressBuilding}' />  <td value='{res[i].fullNameAdministrator}' /> </tr>";
                //ViewBag.BuildingTable += $" </table>";


                ViewBag.BuildingTable += $"<br/> <div> {res[i].id} </div> <div> {res[i].addressBuilding} </div> <div> {res[i].fullNameAdministrator} </div> <br/> ";



                var responseGetBatteries = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Batteries/building/{res[i].id}");
                List<BatteryModel> resBatteries = await responseGetBatteries.Content.ReadAsAsync<List<BatteryModel>>();
                //ViewBag.BatteriesTable += $" <br/><br/> Related batteries of building : {res[i].id}  <table  border=1 width=400 height=500 >";
                for (int j = 0; j < res.Count; j++)
                {
                    //ViewBag.BatteriesTable += $"<tr> <td value='{resBatteries[j].id}' /> <td value='{resBatteries[j].status}' /><td value='{resBatteries[j].dateCommissioning}' /><td value='{resBatteries[j].dateLastInspection}' /><td value='{resBatteries[j].information}' /><td value='{resBatteries[j].notes}' /><td value='{resBatteries[j].batteryType}' /> </tr>";
                    ViewBag.BatteriesTable += $" <div> {resBatteries[j].id} </div> <div> {resBatteries[j].status} </div> <div> {resBatteries[j].dateCommissioning}</div> <div> {resBatteries[j].dateLastInspection}</div> <div> {resBatteries[j].information}</div> <div> {resBatteries[j].notes}</div> <div> {resBatteries[j].batteryType}</div> <div> ";
                }
                // ViewBag.BatteriesTable += $" </table>"; 

            }
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
