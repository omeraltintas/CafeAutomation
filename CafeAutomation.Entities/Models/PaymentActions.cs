using CafeAutomation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class PaymentActions:IEntity
    {
        public int Id { get; set; }
        public string SaleCode { get; set; }
        public string  PaymentType { get; set; }
        public string Description { get; set; }
        public decimal Paid { get; set; }
        public DateTime Date { get; set; }
    }
}
