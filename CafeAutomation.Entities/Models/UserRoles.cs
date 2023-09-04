using CafeAutomation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class UserRoles:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FormName { get; set; }
        public string ControlName { get; set; }
        public string ControlCaption { get; set; }
        public bool IsVisible { get; set; }     
    }
}
