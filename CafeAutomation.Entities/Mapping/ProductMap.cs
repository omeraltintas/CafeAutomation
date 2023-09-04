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
    public class ProductMap:EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.ToTable("Product");
            this.HasKey(x=>x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.UnitPrice).HasPrecision(20, 2);
            this.HasRequired(x=>x.Menu).WithMany(x=>x.Products).HasForeignKey(x=>x.MenuId);
        }
    }
}
