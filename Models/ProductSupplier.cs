using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pita_Pit_Inventory.Models
{
    [Table("Product_Supplier")]
    public partial class ProductSupplier
    {
        [Column("Product_Supplier_Id")]
        public int ProductSupplierId { get; set; }
        [Column("Product_Id")]
        public int? ProductId { get; set; }
        [Column("Supplier_Id")]
        public int? SupplierId { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("ProductSupplier")]
        public Products Product { get; set; }
        [ForeignKey("SupplierId")]
        [InverseProperty("ProductSupplier")]
        public Suppliers Supplier { get; set; }
    }
}
