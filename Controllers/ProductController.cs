using Microsoft.AspNetCore.Mvc;
using Pita_Pit_Inventory.Models;
using Pita_Pit_Inventory.Models.ViewModels;
using System.Dynamic;
using System.Linq;

namespace Pita_Pit_Inventory.Controllers
{
    public class ProductController : Controller
    {
        private PitaPitDbContext _context;

        #region Init
        public ProductController()
        {
            _context = new PitaPitDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Product
        [HttpGet("Product/New")]
        public IActionResult NewProduct(string status)
        {
            dynamic model = new ExpandoObject();
            var groups = _context.Groups.ToList();
            var locations = _context.Locations.ToList();

            model.Groups = groups;
            model.Locations = locations;

            ViewData["Status"] = status;
            return View("NewProduct", model);
        }

        [HttpPost("Product/New/Add")]
        public IActionResult AddProduct(string productSKU, string productName, string productPackSize, string productQtyPack, string productTotalQty, string productPrice, string productGST, string productGroup, string productLocation, string productIsPerishable, string productDescription)
        {
            string LclProductSKU = productSKU;
            string LclProductName = productName;
            string LclProductDescription = productDescription;
            decimal LclProductPrice = decimal.Parse(productPrice);
            decimal LclProductGST = decimal.Parse(productGST);
            string LclProductPackSize = productPackSize;
            int LclProductQtyInPack = int.Parse(productQtyPack);
            int LclProductTotalQty = int.Parse(productTotalQty);
            int LclProductGroupId = int.Parse(productGroup);
            int LclProductLocationId = int.Parse(productLocation);
            bool LclProductIsPerishable = false;

            if (productIsPerishable != null && productIsPerishable.Equals("on"))
                LclProductIsPerishable = true;

            Groups group = _context.Groups.Where(x => x.GroupId == LclProductGroupId).FirstOrDefault<Groups>();
            Locations location = _context.Locations.Where(x => x.LocationId == LclProductLocationId).FirstOrDefault<Locations>();

            Products product = new Products()
            {
                ProductSku = LclProductSKU,
                ProductName = LclProductName,
                ProductDescription = LclProductDescription,
                ProductPrice = LclProductPrice,
                ProductGst = LclProductGST,
                ProductPackSize = LclProductPackSize,
                ProductQtyInPack = LclProductQtyInPack,
                ProductTotalQty = LclProductTotalQty,
                ProductGroupId = LclProductGroupId,
                ProductLocationId = LclProductLocationId,
                ProductIsPerishable = LclProductIsPerishable
                
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("NewProduct", "Product", new { status = "Success" });
        }

        [HttpGet("Product/View")]
        public IActionResult ViewProducts(string status)
        {
            dynamic model = new ExpandoObject();

            var products = (from p in _context.Products
                            join l in _context.Locations on p.ProductLocationId equals l.LocationId
                            join g in _context.Groups on p.ProductGroupId equals g.GroupId
                            select new ProductsViewModel
                            {
                                Id = p.ProductId,
                                Sku = p.ProductSku,
                                Price = p.ProductPrice,
                                Name = p.ProductName,
                                PackSize = p.ProductPackSize,
                                QtyInPack = p.ProductQtyInPack,
                                Location = l.LocationName,
                                Group = g.GroupName,
                                IsPerishable = p.ProductIsPerishable
                            }).ToList();

            model.Products = products;

            ViewData["Status"] = status;
            return View("ViewProducts", model);
        }

        [HttpGet("Product/View/Edit/{id}")]
        public IActionResult EditProduct(int id)
        {
            dynamic model = new ExpandoObject();
            var groups = _context.Groups.ToList();
            var locations = _context.Locations.ToList();
            var product = _context.Products.Where(x => x.ProductId == id);

            model.Groups = groups;
            model.Locations = locations;
            model.Product = product;

            return View("EditProduct", model);
        }

        [HttpGet("Product/View/Delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            Products product = _context.Products.Where(x => x.ProductId == id).FirstOrDefault<Products>();
            _context.Products.Remove(product);
            _context.SaveChanges();

            return RedirectToActionPermanent("ViewProducts", "Product");
        }

        #endregion Product

        #region Groups
        [HttpGet("Product/Groups")]
        public IActionResult Groups(string status)
        {
            dynamic model = new ExpandoObject();
            var groups = _context.Groups.ToList();

            model.Group = null;
            model.Groups = groups;

            ViewData["Status"] = status;
            return View("Groups", model);
        }

        [HttpPost("Product/Groups/Add")]
        public IActionResult AddGroup(string groupName)
        {
            string name = groupName;

            Groups group = new Groups()
            {
                GroupName = name
            };

            _context.Groups.Add(group);
            _context.SaveChanges();

            return RedirectToAction("Groups", "Product", new { status = "Success" });
        }

        [HttpGet("Product/Groups/Edit/{id}")]
        public IActionResult EditGroup(int id)
        {
            var group = _context.Groups.Where(x => x.GroupId == id);
            var groups = _context.Groups.ToList();

            dynamic model = new ExpandoObject();
            model.Group = group;
            model.Groups = groups;

            return View("Groups", model);
        }

        [HttpGet("Product/Groups/Delete/{id}")]
        public IActionResult DeleteGroup(int id)
        {
            Groups group = _context.Groups.Where(x => x.GroupId == id).FirstOrDefault<Groups>();
            _context.Groups.Remove(group);
            _context.SaveChanges();

            return RedirectToActionPermanent("Groups", "Product");
        }
        #endregion

        #region Locations
        [HttpGet("Product/Locations")]
        public IActionResult Locations(string status)
        {
            dynamic model = new ExpandoObject();
            var locations = _context.Locations.ToList();

            model.Location = null;
            model.Locations = locations;

            ViewData["Status"] = status;
            return View("Locations", model);
        }

        [HttpPost("Product/Locations/Add")]
        public IActionResult AddLocation(string locationName)
        {
            string name = locationName;

            Locations location = new Locations()
            {
                LocationName = name
            };

            _context.Locations.Add(location);
            _context.SaveChanges();
           
            return RedirectToAction("Locations", "Product", new { status = "Success" });
        }

        [HttpGet("Product/Locations/Edit/{id}")]
        public IActionResult EditLocation(int id)
        {
            var location = _context.Locations.Where(x => x.LocationId == id);
            var locations = _context.Locations.ToList();

            dynamic model = new ExpandoObject();
            model.Location = location;
            model.Locations = locations;

            return View("Locations", model);
        }

        [HttpGet("Product/Locations/Delete/{id}")]
        public IActionResult DeleteLocation(int id)
        {
            Locations location = _context.Locations.Where(x => x.LocationId == id).FirstOrDefault<Locations>();
            _context.Locations.Remove(location);
            _context.SaveChanges();

            return RedirectToActionPermanent("Locations", "Product");
        }
        #endregion
    }
}