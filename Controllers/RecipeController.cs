using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pita_Pit_Inventory.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Recipe")]
        public IActionResult RecipePage()
        {
            return View("Recipe");
        }

        [HttpGet("Recipe/Ingredient")]
        public IActionResult IngredientPage()
        {
            return View("Ingredient");
        }
    }
}