using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pita_Pit_Inventory.Models
{
    public partial class Suppliers
    {
        public Suppliers()
        {
            ProductSupplier = new HashSet<ProductSupplier>();
        }

        [Key]
        [Column("Supplier_Id")]
        public int SupplierId { get; set; }
        [Column("Supplier_SKU")]
        public string SupplierSku { get; set; }
        [Column("Supplier_Name")]
        public string SupplierName { get; set; }
        [Column("Supplier_Address")]
        public string SupplierAddress { get; set; }
        [Column("Supplier_Email")]
        public string SupplierEmail { get; set; }
        [Column("Supplier_Note")]
        public string SupplierNote { get; set; }

        [InverseProperty("Supplier")]
        public ICollection<ProductSupplier> ProductSupplier { get; set; }
    }
}
