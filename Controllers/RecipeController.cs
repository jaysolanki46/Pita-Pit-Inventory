using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pita_Pit_Inventory.Models;

namespace Pita_Pit_Inventory.Controllers
{
    public class RecipeController : Controller
    {
        private PitaPitDbContext _context;

        public RecipeController()
        {
            _context = new PitaPitDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Recipe")]
        public IActionResult RecipePage()
        {
            return View("Recipe");
        }

        #region Recipe/Ingredient
        [HttpGet("Recipe/Ingredients")]
        public IActionResult Ingredients(string status)
        {
            dynamic model = new ExpandoObject();
            var ingredients = _context.Ingredients.ToList();

            model.Ingredient = null;
            model.Ingredients = ingredients;

            ViewData["Status"] = status;
            return View("Ingredients", model);
        }

        [HttpPost("Recipe/AddIngredient")]
        public IActionResult AddIngredient(string ingredientItemCode, string ingredientItemName, string ingredientItemQty, string ingredientItemSize)
        {
            Ingredients ingredient = new Ingredients()
            {
                IngredientItemCode = ingredientItemCode,
                IngredientItemName = ingredientItemName,
                IngredientItemQtyInSize = int.Parse(ingredientItemQty),
                IngredientItemSize = ingredientItemSize
            };

            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();

            return RedirectToAction("Ingredients", "Recipe", new { status = "Success" });
        }

        [HttpGet("Recipe/Ingredients/Ingredient/{id}")]
        public IActionResult Ingredient(int id)
        {
            var ingredient = _context.Ingredients.Where(x => x.IngredientItemId == id);
            var ingredients = _context.Ingredients.ToList();

            dynamic model = new ExpandoObject();
            model.Ingredient = ingredient;
            model.Ingredients = ingredients;

            return View("Ingredients", model);
        }

        [HttpGet("Recipe/Ingredients/DeleteIngredient/{id}")]
        public IActionResult DeleteIngredient(int id)
        {
            Ingredients ingredient = _context.Ingredients.Where(x => x.IngredientItemId == id).FirstOrDefault<Ingredients>();
            _context.Ingredients.Remove(ingredient);
            _context.SaveChanges();

            return RedirectToActionPermanent("Ingredients", "Recipe");
        }
        #endregion
    }
}