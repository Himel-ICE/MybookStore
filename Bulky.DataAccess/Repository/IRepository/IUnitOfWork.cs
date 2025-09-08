using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepositoty Category { get; }
        IProductRepository Products { get; }
        IProductImageRepositoty ProductImage { get; }
        ICompanyRepositoty Company { get; }
        IShoppingCartRepositoty ShoppingCart { get; }
        IApplicationUserRepositoty ApplicationUser { get; }
        IOrderHeaderRepositoty OrderHeader { get; }
        IOrderDetailRepositoty OrderDetail { get; }
        void Save();
    }
}
