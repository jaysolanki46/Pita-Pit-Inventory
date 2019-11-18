using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pita_Pit_Inventory.Models
{
    public partial class Recipes
    {
        public Recipes()
        {
            RecipeIngredients = new HashSet<RecipeIngredients>();
        }

        [Key]
        [Column("Recipe_Id")]
        public int RecipeId { get; set; }
        [Column("Recipe_Name")]
        public string RecipeName { get; set; }
        [Column("Recipe_Price")]
        public string RecipePrice { get; set; }

        [InverseProperty("Recipe")]
        public ICollection<RecipeIngredients> RecipeIngredients { get; set; }
    }
}
