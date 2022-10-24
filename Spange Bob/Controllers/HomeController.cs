using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spange_Bob.Models;
using System;
using System.Diagnostics;

namespace Spange_Bob.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Frie()
        {
            return View();
        }

        public IActionResult Hom()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Friends(string queary)
        {
            var friends = from f in _dbContext.Friends select f;

            if (!String.IsNullOrEmpty(queary))
            {
                friends = from f in friends where f.FirstName.Contains(queary) select f;
            }

            return View(friends);
        }

        public async Task<IActionResult> Homes()
        {
            return View(await _dbContext.Homes.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}