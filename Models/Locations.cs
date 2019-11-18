using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pita_Pit_Inventory.Models
{
    public partial class Locations
    {
        [Key]
        [Column("Location_Id")]
        public int LocationId { get; set; }
        [Column("Location_Name")]
        public string LocationName { get; set; }
    }
}
