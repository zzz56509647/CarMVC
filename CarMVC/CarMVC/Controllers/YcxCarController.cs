using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CarMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Sakura.AspNetCore;

namespace CarMVC.Controllers
{
    public class YcxCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult GetCars(int pageSize,int? page=1)
        {
            string url = "http://localhost:57894/CarY/getcar";
            HttpClient client = new HttpClient();
            //content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage message = client.GetAsync(url).Result;
            string result = message.Content.ReadAsStringAsync().Result;
            List<AllCarThis> list = JsonConvert.DeserializeObject<List<AllCarThis>>(result);
            pageSize = 3;
            int pageNumber = page ?? 1;
            return View(list.ToPagedList(pageSize,pageNumber));
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