using CafeAutomation.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class CafeContext:DbContext
    {
        public CafeContext() : base("name=connection") 
        {

        }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<TableActions> TableActions { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserActions> UserActions { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<PaymentActions> PaymentActions { get; set; }
        public DbSet<SaleCode> SaleCode { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<ProgramSettings> ProgramSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<CafeContext>(null);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new PaymentActionsMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new SalesMap());
            modelBuilder.Configurations.Add(new TableActionsMap());
            modelBuilder.Configurations.Add(new TablesMap());
            modelBuilder.Configurations.Add(new UserActionsMap());
            modelBuilder.Configurations.Add(new UserRolesMap());
            modelBuilder.Configurations.Add(new UsersMap());
            modelBuilder.Configurations.Add(new CustomersMap());
        }
    }
}
