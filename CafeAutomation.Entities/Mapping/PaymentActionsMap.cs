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
    public class PaymentActionsMap : EntityTypeConfiguration<PaymentActions>
    {
        public PaymentActionsMap()
        {
            this.ToTable("PaymentActions");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
