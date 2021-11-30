using AlgoraArt.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoraArt.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sponsor()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ArtVendorHome()
        {
            return View();
        }
        public IActionResult VolunteerHome()
        {
            return View();
        }

        public IActionResult ArtistsHome()
        {
            return View();
        }
        public IActionResult AlgoraArtSpaces()
        {
            return View();
        }
        public IActionResult CreateStation()
        {
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
