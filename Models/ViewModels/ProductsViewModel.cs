using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pita_Pit_Inventory.Models.ViewModels
{
    public class ProductsViewModel
    {
        public int Id { set; get; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string PackSize { get; set; }
        public int? QtyInPack { get; set; }
        public int? TotalQty { get; set; }
        public string Location { get; set; }
        public string Group { get; set; }
        public bool? IsPerishable { get; set; }

    }
}
