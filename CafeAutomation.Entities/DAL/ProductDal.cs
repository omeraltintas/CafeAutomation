using CafeAutomation.Entities.Models;
using CafeAutomation.Entities.Repository;
using CafeAutomation.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.DAL
{
    public class ProductDal : EntityRepositoryBase<CafeContext, Product,ProductValidator>
    {
        public object ProductList(CafeContext context)
        {
            var list=(from p in context.Product select new
            {
                p.Id,
                p.MenuId,
                Menu=p.Menu.MenuName,
                p.ProductCode,
                p.ProductName,
                p.UnitPrice,
                p.UnitPrice2,
                p.Description,
                p.Image,
                p.Date,
                p.QuickSale
            }).ToList();
            return list;
        }
    }
}
