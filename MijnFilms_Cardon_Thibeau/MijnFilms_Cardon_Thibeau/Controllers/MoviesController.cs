using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MijnFilms_Cardon_Thibeau.Models;

namespace MijnFilms_Cardon_Thibeau.Controllers
{
    [Route("Movies")]
    public class MoviesController : Controller
    {
        private NorthwindContext db;
        public MoviesController(NorthwindContext context)
        {
            db = context;
        }

        [Route("List")]
        public IActionResult List()
        {
            ViewData["Message"] = "List";
            return View();
        }

        [Route("Sort")]
        public IActionResult Sort()
        {
            ViewData["Message"] = "Sort";

            return View();
        }

        [Route("Details")]
        public IActionResult Details()
        {
            ViewData["Message"] = "Details";

            return View();
        }

        [Route("Find")]
        public IActionResult Find()
        {
            ViewData["Message"] = "Find";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class NorthwindContext
    {
    }
}
