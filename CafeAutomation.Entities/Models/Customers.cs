using CafeAutomation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class Customers:IEntity
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
