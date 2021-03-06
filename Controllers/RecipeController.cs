﻿using System;
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
        [HttpGet("Recipe/Recipes")]
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
            model.Recipe = null;

            ViewData["Status"] = status;

            return View("Recipes", model);
        }

        [HttpPost("Recipe/Recipes/Add")]
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

        [HttpGet("Recipe/Recipes/Edit/{id}")]
        public IActionResult EditRecipe(int id)
        {
            dynamic model = new ExpandoObject();

            // Initial form data
            var ingredients = _context.Ingredients.ToList();

            var list = (from r in _context.Recipes
                        join ri in _context.RecipeIngredients on r.RecipeId equals ri.RecipeId
                        join i in _context.Ingredients on ri.IngredientItemId equals i.IngredientItemId
                        where r.RecipeId == id
                        select new
                        {
                            Id = r.RecipeId,
                            Name = r.RecipeName,
                            Price = r.RecipePrice,
                            IngredientList = i.IngredientItemId
                        }).ToList();

            var recipe = list.GroupBy(x => new { x.Id, x.Name, x.Price }).Select(
                            item => new RecipesViewModel
                            {
                                Id = item.Key.Id,
                                Name = item.Key.Name,
                                Price = item.Key.Price,
                                IngredientList = string.Join(",", item.Select(c => c.IngredientList))
                            });

            model.Ingredients = ingredients;
            model.Recipe = recipe;
            model.Recipes = null;

            return View("Recipes", model);
        }

        [HttpGet("Recipe/Recipes/Delete/{id}")]
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

        #region Ingredient
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

        [HttpPost("Recipe/Ingredients/Add")]
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

        [HttpGet("Recipe/Ingredients/Edit/{id}")]
        public IActionResult EditIngredient(int id)
        {
            var ingredient = _context.Ingredients.Where(x => x.IngredientItemId == id);
            var ingredients = _context.Ingredients.ToList();

            dynamic model = new ExpandoObject();
            model.Ingredient = ingredient;
            model.Ingredients = ingredients;

            return View("Ingredients", model);
        }

        [HttpGet("Recipe/Ingredients/Delete/{id}")]
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