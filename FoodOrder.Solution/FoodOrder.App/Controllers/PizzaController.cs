using Microsoft.AspNetCore.Mvc;

namespace FoodOrder.App.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
