using CafeAutomation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class Table:IEntity
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public bool TableStatus { get; set; }
        public bool IsReserved { get; set; }
        public string Description  { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime LastProcessDate { get; set; }
        public string Process { get; set; }
        public string SaleCode { get; set; }
        
        public int? UserId { get; set; }
        public virtual ICollection<TableActions> TableActions { get; set; }
        public virtual Users Users { get; set; }
    }
}
