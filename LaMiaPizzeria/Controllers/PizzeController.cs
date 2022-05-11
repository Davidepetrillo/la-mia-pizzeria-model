using LaMiaPizzeria.Models;
using LaMiaPizzeria.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeria.Controllers
{
    public class PizzeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizze> pizze = PizzeData.GetPizze();

            return View("HomePage", pizze);
        }
    }
}
