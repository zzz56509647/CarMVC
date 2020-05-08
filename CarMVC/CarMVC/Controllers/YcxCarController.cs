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
            string url = "http://localhost:5000/CarY/getcar";
            HttpClient client = new HttpClient();
            //content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage message = client.GetAsync(url).Result;
            string result = message.Content.ReadAsStringAsync().Result;
            List<AllCarThis> list = JsonConvert.DeserializeObject<List<AllCarThis>>(result);
            pageSize = 5;
            int pageNumber = page ?? 1;
            return View(list.ToPagedList(pageSize,pageNumber));
        }

        
        public IActionResult SelectCars(string carN, string carPi,string carT,int pageSize,int? page=1)
        {
            int pin = Convert.ToInt32(carPi);
            int types = Convert.ToInt32(carT);
            string url = $"http://localhost:57894/CarY/selectcar?carname={carN}&carP={pin}&carTyep={types}";
            HttpClient client = new HttpClient();
            AllCarThis allCar = new AllCarThis();
            string str = JsonConvert.SerializeObject(allCar);
            HttpContent content = new StringContent(str);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage message = client.PostAsync(url,content).Result;
            string result = message.Content.ReadAsStringAsync().Result;
            List<AllCarThis> list = JsonConvert.DeserializeObject<List<AllCarThis>>(result);
            pageSize = 5;
            int pageNumber = page ?? 1;
            return View(list.ToPagedList(pageSize, pageNumber));

        }

    }
}