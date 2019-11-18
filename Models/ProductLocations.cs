using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pita_Pit_Inventory.Models
{
    [Table("Product_Locations")]
    public partial class ProductLocations
    {
        public ProductLocations()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        [Column("Product_Location_Id")]
        public int ProductLocationId { get; set; }
        [Column("Product_Location_Name")]
        public string ProductLocationName { get; set; }

        [InverseProperty("ProductLocation")]
        public ICollection<Products> Products { get; set; }
    }
}
