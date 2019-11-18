using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pita_Pit_Inventory.Models
{
    public partial class Groups
    {
        public Groups()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        [Column("Group_Id")]
        public int GroupId { get; set; }
        [Column("Group_Name")]
        public string GroupName { get; set; }

        [InverseProperty("ProductGroup")]
        public ICollection<Products> Products { get; set; }
    }
}
