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
    public class MenuMap:EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            this.HasKey(p=>p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.ToTable("Menu");
            this.Property(p => p.MenuName).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Description).HasColumnType("varchar");
        }
    }
}
