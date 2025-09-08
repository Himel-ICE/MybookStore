using Bulky.DataAccess.Data;
using Bulky.Models.ViewModels;
using Bulky.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            
            var vm = new DashboardVM
            {
                OrderHeaders = _db.OrderHeaders
                .Where(o => o.PaymentStatus == "Pending")
                .ToList(),

                OrderCount = _db.OrderHeaders
                .Count(),

                TotalCell = _db.OrderHeaders
                .Where(o => o.PaymentStatus == "Paid")
                .Sum(o => (double?)o.OrderTotal) ?? 0
            };

            
            var topCategories = _db.OrderDetails
                .Include(od => od.Product)
                .ThenInclude(p => p.Category)
                .GroupBy(od => od.Product.Category.Name)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    OrderCount = g.Sum(x => x.Count)
                })
                .OrderByDescending(c => c.OrderCount)
                .Take(3)
                .ToList();

            vm.TopCategoryNames = topCategories.Select(c => c.CategoryName).ToList();
            vm.TopCategoryCounts = topCategories.Select(c => c.OrderCount).ToList();

            return View(vm);
        }


    }
}
