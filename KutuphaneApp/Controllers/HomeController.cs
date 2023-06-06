using KutuphaneApp.Business.Abstract;
using KutuphaneApp.Business.Concrate;
using KutuphaneApp.Entity.Concrate;
using KutuphaneApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KutuphaneApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly ICategoryService _categoryService;

		public HomeController(ICategoryService categoryService,ILogger<HomeController> logger)
        {
			_categoryService= categoryService;
			_logger = logger;
        }

        public IActionResult Index()
        {
            //_categoryService.Add(new Cateogory() { CategoryName = "Korku" });
            return View();
        }

		public IActionResult Preview()
		{
			//_categoryService.Add(new Cateogory() { CategoryName = "Korku" });
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