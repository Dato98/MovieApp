using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Models;
using Services.Contracts;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUOW _servise;

        public HomeController(ILogger<HomeController> logger, IUOW service)
        {
            _logger = logger;
            _servise = service;
        }

        public IActionResult Index()
        {
            var person = _servise.Person.GetPersonWithMovies(1);
            Movie movie = person.Movies.Where(x => x.Description.Contains("desc")).FirstOrDefault();
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
