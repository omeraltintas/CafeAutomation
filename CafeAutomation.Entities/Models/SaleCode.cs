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
    public class SaleCode:IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Column(TypeName ="varchar")]
        public string SaleDefinition { get; set; }
        public int Count { get; set; }
    }
}
