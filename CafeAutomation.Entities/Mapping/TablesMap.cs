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
    public class TablesMap : EntityTypeConfiguration<Table>
    {
        public TablesMap()
        {
            this.ToTable("Tables");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.AddedDate).HasColumnType("Date");
            this.HasOptional(x=>x.Users).WithMany(x=>x.Tables).HasForeignKey(x=>x.UserId);
        }
    }
}
