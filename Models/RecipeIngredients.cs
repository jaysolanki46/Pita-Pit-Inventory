using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pita_Pit_Inventory.Models
{
    [Table("Recipe_Ingredients")]
    public partial class RecipeIngredients
    {
        [Key]
        [Column("Recipe_Ingredient_Id")]
        public int RecipeIngredientId { get; set; }
        [Column("Recipe_Id")]
        public int? RecipeId { get; set; }
        [Column("Ingredient_Item_Id")]
        public int? IngredientItemId { get; set; }

        [ForeignKey("IngredientItemId")]
        [InverseProperty("RecipeIngredients")]
        public Ingredients IngredientItem { get; set; }
        [ForeignKey("RecipeId")]
        [InverseProperty("RecipeIngredients")]
        public Recipes Recipe { get; set; }
    }
}
