using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pita_Pit_Inventory.Models;
using Pita_Pit_Inventory.Models.ViewModels;

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

        #region Recipes
        [HttpGet("Recipes")]
        public IActionResult Recipes(string status)
        {
            dynamic model = new ExpandoObject();

            // Initial form data
            var ingredients = _context.Ingredients.ToList();

            // View Data
            var list = (from r in _context.Recipes
                        join ri in _context.RecipeIngredients on r.RecipeId equals ri.RecipeId
                        join i in _context.Ingredients on ri.IngredientItemId equals i.IngredientItemId
                        select new
                        {
                            Id = r.RecipeId,
                            Name = r.RecipeName,
                            IngredientList = i.IngredientItemName + " (" + i.IngredientItemQtyInSize + " " + i.IngredientItemSize + ")"
                        }).ToList();

            var recipes = list.GroupBy(x => new { x.Id, x.Name }).Select(
                            item => new RecipesViewModel
                            {
                                Id = item.Key.Id,
                                Name = item.Key.Name,
                                IngredientList = string.Join(",", item.Select(c => c.IngredientList))
                            });

            model.Ingredients = ingredients;
            model.Recipes = recipes;

            ViewData["Status"] = status;

            return View("Recipes", model);
        }

        [HttpPost("Recipes/AddRecipe")]
        public IActionResult AddRecipe(string recipeName, string recipePrice, string[] ingredientList)
        {
            int lastInsertedId = 0;

            // Recipe entry
            Recipes recipe = new Recipes()
            {
                RecipeName = recipeName,
                RecipePrice = recipePrice
            };

            _context.Recipes.Add(recipe);
            _context.SaveChanges();

            lastInsertedId = recipe.RecipeId;

            // Recipe_Ingredients entry (one to many)
            for (int i = 0; i < ingredientList.Length; i++)
            {
                RecipeIngredients recipeIngredients = new RecipeIngredients()
                {
                    IngredientItemId = int.Parse(ingredientList[i]),
                    RecipeId = lastInsertedId
                };

                _context.RecipeIngredients.Add(recipeIngredients);
                _context.SaveChanges();
            }

            return RedirectToAction("Recipes", "Recipe", new { status = "Success" });
        }

        [HttpGet("Recipes/DeleteRecipe/{id}")]
        public IActionResult DeleteRecipe(int id)
        {
            _context.RecipeIngredients.RemoveRange(_context.RecipeIngredients.Where(x => x.RecipeId == id));
            _context.SaveChanges();

            Recipes recipe = _context.Recipes.Where(x => x.RecipeId == id).FirstOrDefault<Recipes>();
            _context.Recipes.Remove(recipe);
            _context.SaveChanges();            

            return RedirectToActionPermanent("Recipes", "Recipe");
        }
        #endregion

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