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
    public class Menu:IEntity
    {      
        public int Id { get; set; }
        public string MenuName { get; set; }     
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
