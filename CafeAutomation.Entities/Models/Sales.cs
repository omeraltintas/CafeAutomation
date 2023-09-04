using CafeAutomation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class Sales:IEntity
    {
        public int Id { get; set; }
        public string SaleCode { get; set; }
        public int? CustomerId { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal Paid { get; set; }
        public decimal Remainder { get; set; }
        public string Description { get; set; }
        public DateTime LastProcessDate { get; set; }
        public bool IsOrderDelivery { get; set; } = false;
        public virtual Customers Customers { get; set; }
    }
}
