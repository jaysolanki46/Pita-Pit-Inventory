using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pita_Pit_Inventory.Models.ViewModels
{
    public class SuppliersViewModel
    {
        public int Id { set; get; }
        public string SKU { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Note { set; get; }
        public string ProductList { set; get; }
    }
}
