using CafeAutomation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class UserActions:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public virtual Users Users { get; set; }
    }
}
