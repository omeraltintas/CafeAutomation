using CafeAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Mapping
{
    public class UserActionsMap : EntityTypeConfiguration<UserActions>
    {
        public UserActionsMap()
        {
            this.ToTable("UserActions");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasRequired(x=>x.Users).WithMany(x=>x.UserActions).HasForeignKey(x=>x.UserId);
        }
    }
}
