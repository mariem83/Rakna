using Microsoft.AspNetCore.Mvc;
using Rakna.Models;
using System.Diagnostics;

namespace Rakna.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return PartialView();
        }

        public IActionResult AboutUs()
        {
            return PartialView();
            
        }

        public IActionResult OurApp()
        {
            return PartialView();
        }
        public IActionResult pricing()
        {
            return PartialView();
        }

        public IActionResult dashbourd()
        {
            return PartialView();
        }
        public IActionResult register()
        {
            return PartialView();
        }

        public IActionResult sendMail()
        {
            return PartialView();
        }
        public IActionResult signin()
        {
            return PartialView();
        }

        public IActionResult support()
        {
            return PartialView();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}