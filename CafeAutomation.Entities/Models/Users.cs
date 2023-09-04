using CafeAutomation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class Users:IEntity
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsActive { get; set; } = true;
        public string ReminderQuestion { get; set; }
        public string Answer { get; set; }
        public bool IsAdmin { get; set; } = false;
        public virtual ICollection<UserActions> UserActions { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
    }
}
