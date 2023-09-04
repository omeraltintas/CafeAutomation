using CafeAutomation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    [Table("ProgramSettings")]
    public class ProgramSettings:IEntity
    {
        public int Id { get; set; }
        public string OptionDefinition { get; set; }
        public string OptionName { get; set; }
    }
}
