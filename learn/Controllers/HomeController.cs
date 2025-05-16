using System.Diagnostics;
using learn.Models;
using Microsoft.AspNetCore.Mvc;

namespace learn.Controllers
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
            ViewBag.name = "uvw";
            ViewBag.x = "xyz";
            ViewBag.num = 123;
            string[] arrr = { "a", "b", "c" };
            ViewBag.array = arrr;

            Employee Me = new Employee();
            {
                Me.EmpID = 11;
                Me.EmpName = "ABC";
                Me.EmpDesignation = "designer";
            }
            ViewBag.e = Me;
            TempData["Message"] = "form submit successfull!";
            //Session["var1"] = "data of session !";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["x"] = "abc";
            ViewBag.y = "xyz";

            TempData.Keep();
            //string[] arrr = { "a", "b", "c" };
            //TempData["array"] = arrr;

            return View();
        }
        public IActionResult AA()
        {
            return View();
        }
      
        public IActionResult Showw()
        {
            ViewData["x"] = "abc";
            ViewData["y"] = DateTime.Now.ToString();
            string[] arr = { "a", "b", "c" };
            ViewData["array"] = arr;
            //int[] numbers = { 10, 20, 30 };

            Employee Me = new Employee();
            {
                Me.EmpID = 11;
                Me.EmpName = "ABC";
                Me.EmpDesignation = "designer";
            }
            ViewData["EMP"] = Me;
            return View();
        }
        
        public IActionResult Create()
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
