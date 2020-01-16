using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductApp.Models;
using ProductApp.Models.ViewModels;

namespace ProductApp.Controllers
{
    public class HomeController : Controller
    {
        private Context context;

        private readonly ILogger<HomeController> _logger;
       
        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Products.Include(x => x.Category).ToList());
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
