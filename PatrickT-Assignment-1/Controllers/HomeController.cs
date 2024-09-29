using Microsoft.AspNetCore.Mvc;
using PatrickT_Assignment_1.Models;
using System.Diagnostics;

namespace PatrickT_Assignment_1.Controllers
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
            return View();
        }

        public IActionResult AllListings()
        {
            return View();
        }

        public IActionResult AvailableEquipment()
        {
            return View();
        }

        public IActionResult RequestForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RequestForm(EquipmentRequest equipmentRequest)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRequest(equipmentRequest);
                return View("Confirmation", equipmentRequest);
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
