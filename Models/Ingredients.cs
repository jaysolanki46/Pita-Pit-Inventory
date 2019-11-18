using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pita_Pit_Inventory.Models
{
    public partial class Ingredients
    {
        public Ingredients()
        {
            RecipeIngredients = new HashSet<RecipeIngredients>();
        }

        [Key]
        [Column("Ingredient_Item_Id")]
        public int IngredientItemId { get; set; }
        [Column("Ingredient_Item_code")]
        public string IngredientItemCode { get; set; }
        [Column("Ingredient_Item_Name")]
        public string IngredientItemName { get; set; }
        [Column("Ingredient_Item_Size")]
        public string IngredientItemSize { get; set; }
        [Column("Ingredient_Item_Qty_In_Size")]
        public int? IngredientItemQtyInSize { get; set; }

        [InverseProperty("IngredientItem")]
        public ICollection<RecipeIngredients> RecipeIngredients { get; set; }
    }
}
