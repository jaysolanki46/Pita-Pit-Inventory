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

        [HttpGet("Supplier/New")]
        public IActionResult AddSupplierPage()
        {
            return View("NewSupplier");
        }

        [HttpGet("Supplier/View")]
        public IActionResult ViewSuppliersPage()
        {
            return View("ViewSuppliers");
        }

        [HttpPost]
        public IActionResult Add(string supplierCode, string supplierName, string supplierAddress, string supplierEmail, string productGroup, string supplierNote)
        {
            string code = supplierCode;
            string name = supplierName;
            string address = supplierAddress;
            string mail = supplierEmail;
            string note = supplierNote;

            return RedirectToAction("New", "Supplier", new { status = "Success" });
        }
    }
}