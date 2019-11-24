using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pita_Pit_Inventory.Models.ViewModels
{
    public class RecipesViewModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Price { set; get; }
        public string IngredientList { set; get; }
    }
}
