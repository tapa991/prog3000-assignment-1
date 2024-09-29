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
            var equipment = GetEquipmentList();
            return View(equipment);
        }

        public IActionResult AvailableEquipment()
        {
            var equipment = GetEquipmentList();
            return View(equipment);
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

        private List<Equipment> GetEquipmentList()
        {
            return new List<Equipment>
            {
                new Equipment {Id  = 1, Description = "Lenovo Thinkpad", Available = true},
                new Equipment {Id  = 2, Description = "Chromebook", Available = false},
                new Equipment {Id  = 3, Description = "IPhone", Available = true},
                new Equipment {Id  = 4, Description = "Google Pixel", Available = true},
                new Equipment {Id  = 5, Description = "IPad", Available = false},
                new Equipment {Id  = 6, Description = "IPad Mini", Available = false},
                new Equipment {Id  = 7, Description = "Raspberry Pi", Available = true},
            };
        }
    }
}
