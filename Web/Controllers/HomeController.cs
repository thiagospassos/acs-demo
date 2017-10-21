using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private HttpClient ApiXClient
        {
            get
            {
                var client = new HttpClient { BaseAddress = new Uri("apix") };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client;
            }
        }

        public async Task<IActionResult> Index()
        {
            var response = await ApiXClient.GetAsync("/");
            if (response.IsSuccessStatusCode)
            {
                View(new { Code = response.StatusCode, Content = await response.Content.ReadAsStringAsync() });
            }

            return View(new { Code = response.StatusCode });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";



            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
