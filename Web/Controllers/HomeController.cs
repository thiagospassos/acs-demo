using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
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

                var client = new HttpClient { BaseAddress = new Uri("http://apix") };
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
                var stream = await response.Content.ReadAsStreamAsync();
                var serializer = new DataContractJsonSerializer(typeof(List<string>));
                var content = (List<string>) serializer.ReadObject(stream);
                return View(new ApiXResponse { Code = response.StatusCode.ToString(), Values = content });
            }

            return View(new ApiXResponse { Code = response.StatusCode.ToString() });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
