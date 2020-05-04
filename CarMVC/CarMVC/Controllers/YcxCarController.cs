using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CarMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarMVC.Controllers
{
    public class YcxCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetCars()
        {
            string url = "http://localhost:57894/CarY/getcar";
            HttpClient client = new HttpClient();
            //content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage message = client.GetAsync(url).Result;
            string result = message.Content.ReadAsStringAsync().Result;
            List<AllCarThis> list = JsonConvert.DeserializeObject<List<AllCarThis>>(result);

            return View(list.ToList());
        }

        public IActionResult SelectCars()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SelectCars(string carN,string carPi,string CarT)
        {
            string url = "http://localhost:57894/CarY/selectcar";
            HttpClient client = new HttpClient();
            AllCarThis car = new AllCarThis();
            string strOper = JsonConvert.SerializeObject(car);
            HttpContent content = new StringContent(strOper);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage message = client.GetAsync(url).Result;
            string result = message.Content.ReadAsStringAsync().Result;
            List<AllCarThis> list = JsonConvert.DeserializeObject<List<AllCarThis>>(result);

            return Ok(list.ToList());

        }

    }
}