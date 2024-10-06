using AspNetCoreMVC_AreaTemplate.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_AreaTemplate.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class OrderController : Controller
    {
        private readonly NorthwindContext _context;
        public OrderController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var orders = _context.Orders.ToList();
            return View(orders);
        }
    }
}
