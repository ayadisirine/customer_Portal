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
        public string iduser;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string id)
        {
            if (id == null)
                return View();

                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseGet = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Customers/id/{id}");
                List<UesrModel> res = await responseGet.Content.ReadAsAsync<List<UesrModel>>();

                ViewData["username"] = res[0].technicalAuthorityEmail ;

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

            ViewBag.BuildingTable += $"<table border=1 width=100% > ";
            ViewBag.BuildingTable += $"<tr><td>id</td><td>Address Building </td><td>Full Name Administrator</td></tr> ";
            for (int i = 0; i < res.Count; i++)
            {
                // ViewBag.BuildingTable += $" <br/><br/> <table border=1 width=400 height=500>";
                //      ViewBag.BuildingTable += $"<table border=1 width=400 height=500 style=color:red, 'font-family:\"Courier New\", Courier, monospace; font-size:80%'><tr> <td value='{res[i].id}' />  <td value='{res[i].addressBuilding}' />  <td value='{res[i].fullNameAdministrator}' /> </tr></table>";
                // ViewBag.BuildingTable += $"<tr> <td value='{res[i].id}' />  <td value='{res[i].addressBuilding}' />  <td value='{res[i].fullNameAdministrator}' /> </tr>";
                //ViewBag.BuildingTable += $" </table>";


               // ViewBag.BuildingTable += $"<br> <br> <div> {res[i].id} </div> <div style='display: inline'> {res[i].addressBuilding} </div> <div style='display: inline'> {res[i].fullNameAdministrator} </div> <br/> ";
                ViewBag.BuildingTable += $"<tr><td>{res[i].id}</td><td>{res[i].addressBuilding} </td><td>{res[i].fullNameAdministrator}</td></tr> ";


                var responseGetBatteries = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Batteries/building/{res[i].id}");
                List<BatteryModel> resBatteries = await responseGetBatteries.Content.ReadAsAsync<List<BatteryModel>>();
                


                ViewBag.BatteriesTable += $" <br/><br/> Related Batteries of Buildings : {res[i].id} >";
                ViewBag.BatteriesTable += $"<table border=1 width=100% > ";
                ViewBag.BatteriesTable += $"<tr><td>id</td><td>Status </td><td>dateCommissioning</td></tr> ";
                for (int j = 0; j < resBatteries.Count; j++)
                {
                    ViewBag.BatteriesTable += $"<tr><td>{resBatteries[j].id} </td><td>{resBatteries[j].status}</td><td>{resBatteries[j].dateCommissioning}</td></tr>";

                    var responseGetColumns = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Columns/battery/{resBatteries[j].id}");
                    List<ColumnModel> resColumns = await responseGetColumns.Content.ReadAsAsync<List<ColumnModel>>();

                    ViewBag.ColumnsTable += $" <br/><br/> Related Colmun of Battery : {resBatteries[j].id} >";
                    ViewBag.ColumnsTable += $"<table border=1 width=100% > ";
                    ViewBag.ColumnsTable += $"<tr><td>id</td><td>Number of floor served </td><td>Status</td><td>ColumnType</td></tr> ";

                    for (int k = 0; k < resColumns.Count; k++)
                    {
                        //ViewBag.ColumnsTable += $"<br> <br> <div style=' margin - left:85px; '> {resColumns[k].Id} </div> <div style='display: inline - block; margin - left:85px; '> {resColumns[k].NumberOfFloorsServed} </div>  <div style='display: inline - block; margin - left:85px; '> {resColumns[k].Status}</div> </div> <div style='display: inline - block; margin - left:85px; '> {resColumns[k].ColumnType}</div>";
                        ViewBag.ColumnsTable += $"<tr><td>{resColumns[k].Id} </td><td>{resColumns[k].NumberOfFloorsServed}</td><td>{resColumns[k].Status}</td><td>{resColumns[k].ColumnType}</td></tr>";


                        var responseGetElevator = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Elevators/columns/{resColumns[k].Id}");
                        List<ElevatorModel> resElevator = await responseGetElevator.Content.ReadAsAsync<List<ElevatorModel>>();
                        ViewBag.ElevatorTable += $" <br/><br/> Related Elevators of Columns : {resColumns[k].Id} : ";
                        ViewBag.ElevatorTable += $"<table border=1 width=100% > ";
                        ViewBag.ElevatorTable += $"<tr><td>id</td><td>Serial Number </td><td>Status</td> ";
                        for (int H = 0; H < resElevator.Count; H++)
                        {
                           // ViewBag.ElevatorTable += $"<br> <br> <div style=' margin - left:85px; '> {resElevator[H].Id} </div> <div style='display: inline - block; margin - left:85px; '> {resElevator[H].SerialNumber} </div>  <div style='display: inline - block; margin - left:85px; '> {resElevator[H].Status}</div> </div> <div style='display: inline - block; margin - left:85px; '> {resElevator[H].ElevatorType }</div>";
                            ViewBag.ElevatorTable += $"<tr><td>{resElevator[H].Id} </td><td>{resElevator[H].SerialNumber}</td><td>{resElevator[H].Status}</td></tr>";
                        }
                        ViewBag.ElevatorTable += $"</table> ";
                    }
                    ViewBag.ColumnsTable += $"</table> <br/> <br/>";


                }
                ViewBag.BatteriesTable += $"<table > <br/> <br/>";
                // ViewBag.BatteriesTable += $" </table>"; 


            }
            ViewBag.BuildingTable += $"<table > <br/> <br/>";
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


        public async Task<IActionResult> Intervention(long id)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseGet = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Customers/id/{id}");
            List<UesrModel> res = await responseGet.Content.ReadAsAsync<List<UesrModel>>();
            ViewBag.customer = res[0];

       
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
             responseGet = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Buildings/customer/{id}");
            List<BuildingModel> resBuildings = await responseGet.Content.ReadAsAsync<List<BuildingModel>>();

            for (int i = 0; i < res.Count; i++)
            {
                ViewBag.BuildingTable += $"<option value='{ resBuildings[i].id}'> {resBuildings[i].id} </option> ";
            
                ViewBag.BatteryTable = new List<BuildingModel>();

                var responseGetBatteries = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Batteries/building/{res[i].id}");
                List<BatteryModel> resBatteries = await responseGetBatteries.Content.ReadAsAsync<List<BatteryModel>>();


                for (int j = 0; j < resBatteries.Count; j++)
                {
                    ViewBag.BatteriesTable += $"<option value='{ resBatteries[i].id}'> {resBatteries[i].id} </option> ";

                    var responseGetColumns = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Columns/battery/{resBatteries[j].id}");
                    List<ColumnModel> resColumns = await responseGetColumns.Content.ReadAsAsync<List<ColumnModel>>();

                    for (int k = 0; k < resColumns.Count; k++)
                    {
                        ViewBag.ColumnsTable += $"<option value='{ resColumns[i].Id}'> {resColumns[i].Id} </option> ";

                        var responseGetElevator = await httpClient.GetAsync(requestUri: $"https://sirinerocketelevatorsrestapi.azurewebsites.net/api/Elevators/columns/{resColumns[k].Id}");
                        List<ElevatorModel> resElevator = await responseGetElevator.Content.ReadAsAsync<List<ElevatorModel>>();
 
                        for (int H = 0; H < resElevator.Count; H++)
                        {
                            ViewBag.ElevatorTable += $"<option value='{ resElevator[H].Id}'> resElevator[H].Id </option> ";

                        }
                        ViewBag.ElevatorTable += $"</table> ";
                    }
                    ViewBag.ColumnsTable += $"</table> <br/> <br/>";


                }
                ViewBag.BatteriesTable += $"<table > <br/> <br/>";
                // ViewBag.BatteriesTable += $" </table>"; 


            }
            ViewBag.BuildingTable += $"<table > <br/> <br/>";
            return View();





        }
    }
}
