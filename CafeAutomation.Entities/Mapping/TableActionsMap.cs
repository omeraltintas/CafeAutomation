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
    public class TableActionsMap : EntityTypeConfiguration<TableActions>
    {
        public TableActionsMap()
        {
            this.ToTable("TableActions");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasOptional(x=>x.Table).WithMany(x=>x.TableActions).HasForeignKey(x=>x.TableId);
            this.HasRequired(x => x.Product).WithMany(x => x.TableActions).HasForeignKey(x => x.ProductId);
        }
    }
}
