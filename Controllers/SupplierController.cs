using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pita_Pit_Inventory.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Supplier/Add")]
        public IActionResult AddSupplierPage()
        {
            return View("AddSupplier");
        }

        [HttpGet("Supplier/View")]
        public IActionResult ViewSuppliersPage()
        {
            return View("ViewSuppliers");
        }
    }
}