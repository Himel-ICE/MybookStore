using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models.ViewModels
{
    public class DashboardVM
    {
        public double TotalCell { get; set; }
        public int OrderCount { get; set; }
        public List<OrderHeader> OrderHeaders { get; set; } = new();
        public OrderDetails Details { get; set; }
        public List<string> TopCategoryNames { get; set; } = new();
        public List<int> TopCategoryCounts { get; set; } = new();
    }
}
