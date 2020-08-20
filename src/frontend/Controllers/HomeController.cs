using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SampleFrontend.Models;

namespace SampleFrontend.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public IHttpClientFactory ClientFactory { get; }
        public IConfiguration Configuration { get; }

        public HomeController (IHttpClientFactory clientFactory, IConfiguration configuration, ILogger<HomeController> logger) {
            ClientFactory = clientFactory;
            Configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index () {
            var requestUrl = Configuration.GetValue<string> ("API_URL");
            var request = new HttpRequestMessage (HttpMethod.Get, requestUrl);

            var client = ClientFactory.CreateClient ();
            var response = client.SendAsync (request).GetAwaiter ().GetResult ();
            var body = response.Content.ReadAsStringAsync ().GetAwaiter ().GetResult ();
            ViewData["Response"] = body;
            return View ();
        }

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}