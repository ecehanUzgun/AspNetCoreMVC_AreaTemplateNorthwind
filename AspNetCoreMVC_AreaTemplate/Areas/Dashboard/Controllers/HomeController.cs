using AspNetCoreMVC_AreaTemplate.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_AreaTemplate.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : Controller
    {
        private readonly NorthwindContext _context;

        public HomeController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            //ViewBag.OrderCount
            ViewBag.OrderCount = _context.Orders.Count();

            //ViewBag.ProductCount
            ViewBag.ProductCount=_context.Products.Count();

            //ViewBag.TotalRevenue
            ViewBag.TotalRevenue = _context.OrderDetails.Sum(x => x.UnitPrice * x.Quantity);


            //ViewBag.EmployeeCount
            ViewBag.EmployeeCount = _context.Employees.Count();




            var orders = _context.Orders.ToList();
            return View(orders);
        }
    }
}
