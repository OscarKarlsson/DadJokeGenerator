using DadJokeGenerator.Application;
using DadJokeGenerator.DTO;
using DadJokeGenerator.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DadJokeGenerator.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DadJokeManager _dadJokeManager;

        public HomeController(ILogger<HomeController> logger, DadJokeManager dadJokeManager)
        {
            _logger = logger;
            _dadJokeManager = dadJokeManager;
        }

        public async Task<IActionResult> Index()
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
