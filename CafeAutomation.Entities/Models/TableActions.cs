using CafeAutomation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{

    public class TableActions:IEntity
    {
        public int Id { get; set; }
        public int? TableId { get; set; }
        //public int MenuId { get; set; }
        public int ProductId { get; set; }
        public string SaleCode { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        //public decimal DiscountPrice { get; set; }
        public decimal DiscountPercentage { get; set; } = 0;
        public string Description { get; set; }
        public DateTime Date { get; set; }
        
        public virtual Table Table { get; set; }
        public virtual Product Product { get; set; }
    }
}
