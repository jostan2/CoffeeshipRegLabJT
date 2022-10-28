using CoffeeshipRegLabJT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeshipRegLabJT.Controllers
{
    public class HomeController : Controller
    {
        CoffeShopDbContext db = new CoffeShopDbContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RegisterForm()
        {
            return View();
        }

        public IActionResult Result(Login l)
        {
            return View(l);
        }

        public IActionResult ProductList()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }

        public IActionResult Product1Details(int Id)
        {
            Product product1 = db.Products.Find(Id = 1);
            return View(product1);
        }

        public IActionResult Product2Details(int Id)
        {
            Product product2 = db.Products.Find(Id = 2);
            return View(product2);
        }

        public IActionResult Product3Details(int Id)
        {
            Product product3 = db.Products.Find(Id = 3);
            return View(product3);
        }

        public IActionResult Product4Details(int Id)
        {
            Product product4 = db.Products.Find(Id = 4);
            return View(product4);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}