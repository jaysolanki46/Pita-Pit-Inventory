﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pita_Pit_Inventory.Models;
using Pita_Pit_Inventory.Models.ViewModels;

namespace Pita_Pit_Inventory.Controllers
{
    public class SupplierController : Controller
    {
        private PitaPitDbContext _context;

        #region Init
        public SupplierController()
        {
            _context = new PitaPitDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Supplier
        [HttpGet("Supplier/New")]
        public IActionResult NewSupplier(string status)
        {
            dynamic model = new ExpandoObject();
            var products = _context.Products.ToList();

            model.Products = products;
            model.Supplier = null;
            ViewData["Status"] = status;
            
            return View("NewSupplier", model);
        }

        [HttpPost("Supplier/New/Add")]
        public IActionResult AddSupplier(string supplierSKU, string supplierName, string supplierAddress, string supplierEmail, string[] productList, string supplierNote)
        {
            int lastInsertedId = 0;

            // Supplier entry
            Suppliers supplier = new Suppliers()
            {
                SupplierSku = supplierSKU,
                SupplierName = supplierName,
                SupplierAddress = supplierAddress,
                SupplierEmail = supplierEmail,
                SupplierNote = supplierNote
            };

            _context.Suppliers.Add(supplier);
            _context.SaveChanges();

            lastInsertedId = supplier.SupplierId;

            // Product_Supplier entry (one to many)
            for (int i = 0; i < productList.Length; i++)
            {
                ProductSupplier productSupplier = new ProductSupplier()
                {
                    ProductId = int.Parse(productList[i]),
                    SupplierId = lastInsertedId
                };

                _context.ProductSupplier.Add(productSupplier);
                _context.SaveChanges();
            }
            return RedirectToAction("NewSupplier", "Supplier", new { status = "Success" });
        }

        [HttpGet("Supplier/View")]
        public IActionResult ViewSuppliers()
        {
            dynamic model = new ExpandoObject();

            var list = (from s in _context.Suppliers
                             join ps in _context.ProductSupplier on s.SupplierId equals ps.SupplierId
                             join pd in _context.Products on ps.ProductId equals pd.ProductId
                             select new 
                             {
                                 Id = s.SupplierId,
                                 Name = s.SupplierName,
                                 Email = s.SupplierEmail,
                                 SKU = s.SupplierSku,
                                 Note = s.SupplierNote,
                                 ProductList = pd.ProductName
                             }).ToList();

            var suppliers = list.GroupBy(x => new { x.Id, x.Name, x.SKU, x.Email, x.Note }).Select(
                            item => new SuppliersViewModel
                            {
                                Id = item.Key.Id,
                                Name = item.Key.Name,
                                Email = item.Key.Email,
                                SKU = item.Key.SKU,
                                Note = item.Key.Note,
                                ProductList = string.Join(",", item.Select(c => c.ProductList))
                            });

            model.Suppliers = suppliers;

            return View("ViewSuppliers", model);
        }

        [HttpGet("Supplier/View/Edit/{id}")]
        public IActionResult EditSupplier(int id)
        {
            dynamic model = new ExpandoObject();

            var list = (from s in _context.Suppliers
                        join ps in _context.ProductSupplier on s.SupplierId equals ps.SupplierId
                        join pd in _context.Products on ps.ProductId equals pd.ProductId
                        where s.SupplierId == id
                        select new
                        {
                            Id = s.SupplierId,
                            Name = s.SupplierName,
                            Address = s.SupplierAddress,
                            Email = s.SupplierEmail,
                            SKU = s.SupplierSku,
                            Note = s.SupplierNote,
                            ProductList = pd.ProductId
                        }).ToList();

            var supplier = list.GroupBy(x => new { x.Id, x.Name, x.Address, x.SKU, x.Email, x.Note }).Select(
                            item => new SuppliersViewModel
                            {
                                Id = item.Key.Id,
                                Name = item.Key.Name,
                                Address = item.Key.Address,
                                Email = item.Key.Email,
                                SKU = item.Key.SKU,
                                Note = item.Key.Note,
                                ProductList = string.Join(",", item.Select(c => c.ProductList))
                            });

            var products = _context.Products.ToList();
            model.Products = products;
            model.Supplier = supplier;

            return View("NewSupplier", model);
        }

        [HttpGet("Supplier/View/Delete/{id}")]
        public IActionResult DeleteSupplier(int id)
        {
            _context.ProductSupplier.RemoveRange(_context.ProductSupplier.Where(x => x.SupplierId == id));
            _context.SaveChanges();

            Suppliers supplier = _context.Suppliers.Where(x => x.SupplierId == id).FirstOrDefault<Suppliers>();
            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();

            return RedirectToAction("EditSupplier", "Supplier");
        }
        #endregion

    }
}