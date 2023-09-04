namespace CafeAutomation.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuName = c.String(),
                        Description = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuId = c.Int(nullable: false),
                        ProductCode = c.String(maxLength: 8000, unicode: false),
                        ProductName = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitPrice2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menu", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "MenuId", "dbo.Menu");
            DropIndex("dbo.Product", new[] { "MenuId" });
            DropTable("dbo.Product");
            DropTable("dbo.Menu");
        }
    }
}
