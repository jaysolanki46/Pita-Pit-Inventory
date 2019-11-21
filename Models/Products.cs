using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pita_Pit_Inventory.Models
{
    public partial class Products
    {
        public Products()
        {
            ProductSupplier = new HashSet<ProductSupplier>();
        }

        [Key]
        [Column("Product_Id")]
        public int ProductId { get; set; }
        [Column("Product_SKU")]
        public string ProductSku { get; set; }
        [Column("Product_Name")]
        public string ProductName { get; set; }
        [Column("Product_Description")]
        public string ProductDescription { get; set; }
        [Column("Product_Price")]
        public decimal? ProductPrice { get; set; }
        [Column("Product_GTS")]
        public decimal? ProductGts { get; set; }
        [Column("Product_Pack_Size")]
        public string ProductPackSize { get; set; }
        [Column("Product_Qty_In_Pack")]
        public int? ProductQtyInPack { get; set; }
        [Column("Product_Group_Id")]
        public int? ProductGroupId { get; set; }
        [Column("Product_Location_Id")]
        public int? ProductLocationId { get; set; }
        [Column("Product_Is_Perishable")]
        public bool? ProductIsPerishable { get; set; }

        [ForeignKey("ProductGroupId")]
        [InverseProperty("Products")]
        public Groups ProductGroup { get; set; }
        [ForeignKey("ProductLocationId")]
        [InverseProperty("Products")]
        public Locations ProductLocation { get; set; }
        [InverseProperty("Product")]
        public ICollection<ProductSupplier> ProductSupplier { get; set; }
    }
}
