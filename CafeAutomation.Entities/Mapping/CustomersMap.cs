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
    public class CustomersMap : EntityTypeConfiguration<Customers>
    {
        public CustomersMap()
        {
            this.ToTable("Customers");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.NameSurname).HasColumnType("varchar").HasMaxLength(150);
            this.Property(x => x.Phone).HasColumnType("varchar").HasMaxLength(150);
            this.Property(x => x.Adress).HasColumnType("varchar").HasMaxLength(150);
            this.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(150);
            this.Property(x => x.Description).HasColumnType("varchar").HasMaxLength(150);

        }
    }
}
