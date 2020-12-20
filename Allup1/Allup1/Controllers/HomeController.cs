using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Allup1.Models;
using Allup1.DAL;
using Allup1.ViewModels;

namespace Allup1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //HomeVM homeVM = new HomeVM
            //{
            //    Categories = _context.Categories.Where(c => c.IsMain == true && c.IsDeleted == false).ToList(),


            //};
            //return View(homeVM);
            return View(_context.Categories.Where(c => c.IsMain == true && c.IsDeleted == false).ToList());
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
