using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationalParks.Models;
using NationalParks.APIHandlerManager;
using Newtonsoft.Json;

namespace NationalParks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Schools()
        {
            APIHandler webHandler = new APIHandler();
            Schools schools = GetSchools(webHandler);

            return View(Schools);
        }

        private static Schools GetSchools(APIHandler webHandler)
        {
            return webHandler.Schools;
        }

        private IActionResult View(Func<IActionResult> schools)
        {
            throw new NotImplementedException();
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
