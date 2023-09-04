using CafeAutomation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPrice2 { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public bool QuickSale { get; set; } = false;
        public virtual Menu Menu { get; set; }
        public virtual ICollection<TableActions> TableActions { get; set; }
    }
}
