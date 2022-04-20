using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ooui.AspNetCore;
using Portfolio.Models;
using Portfolio.Views;
using System.Diagnostics;
using Xamarin.Forms;

namespace Portfolio.Controllers {
    public class HomeController:Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController (ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index () {
            var page = new Overview();
            var element = page.GetOouiElement();
            return new ElementResult(element, "Minha Nossa!");        }

        public IActionResult Privacy () {
            return View();
        }

        [ResponseCache(Duration = 0,Location = ResponseCacheLocation.None,NoStore = true)]
        public IActionResult Error () {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
