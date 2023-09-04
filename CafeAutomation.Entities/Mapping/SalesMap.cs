using CafeAutomation.Entities.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Mapping
{
    public class SalesMap : EntityTypeConfiguration<Sales>
    {
        public SalesMap()
        {
            this.ToTable("Sales");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasOptional(x=>x.Customers).WithMany(x=>x.Sales).HasForeignKey(x=>x.CustomerId);
        }
    }
}
