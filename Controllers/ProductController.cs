using Microsoft.AspNetCore.Mvc;
using Pita_Pit_Inventory.Models;
using System.Dynamic;
using System.Linq;

namespace Pita_Pit_Inventory.Controllers
{
    public class ProductController : Controller
    {
        private PitaPitDbContext _context;

        public ProductController()
        {
            _context = new PitaPitDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Product/New")]
        public IActionResult NewProductPage()
        {
            return View("NewProduct");
        }

        [HttpGet("Product/View")]
        public IActionResult ViewProductsPage()
        {
            return View("ViewProducts");
        }

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

        [HttpPost("Product/Groups/AddGroup")]
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

        [HttpGet("Product/Groups/Group/{id}")]
        public IActionResult Group(int id)
        {
            var group = _context.Groups.Where(x => x.GroupId == id);
            var groups = _context.Groups.ToList();

            dynamic model = new ExpandoObject();
            model.Group = group;
            model.Groups = groups;

            return View("Groups", model);
        }

        [HttpGet("Product/Groups/DeleteGroup/{id}")]
        public IActionResult DeleteGroup(int id)
        {
            Groups group = _context.Groups.Where(x => x.GroupId == id).FirstOrDefault<Groups>();
            _context.Groups.Remove(group);
            _context.SaveChanges();

            return RedirectToActionPermanent("Groups", "Product");
        }

        [HttpGet("Product/Locations")]
        public IActionResult Locations(string status)
        {
            ViewData["Status"] = status;
            return View("Locations");
        }

        [HttpPost("Product/Locations/AddLocation")]
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
    }
}