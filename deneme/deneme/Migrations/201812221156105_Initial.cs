namespace deneme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.DepartmentManagers", new[] { "FormatManagerId" });
            DropIndex("dbo.FormatManagers", new[] { "RegionalManagerId" });
            DropIndex("dbo.RegionalManagers", new[] { "MarketId" });
            AddColumn("dbo.DepartmentManagers", "Age", c => c.Byte(nullable: false));
            AddColumn("dbo.FormatManagers", "Age", c => c.Byte(nullable: false));
            AddColumn("dbo.RegionalManagers", "Age", c => c.Byte(nullable: false));
            CreateIndex("dbo.DepartmentManagers", "formatManagerId");
            CreateIndex("dbo.FormatManagers", "regionalManagerId");
            CreateIndex("dbo.RegionalManagers", "marketId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.RegionalManagers", new[] { "marketId" });
            DropIndex("dbo.FormatManagers", new[] { "regionalManagerId" });
            DropIndex("dbo.DepartmentManagers", new[] { "formatManagerId" });
            DropColumn("dbo.RegionalManagers", "Age");
            DropColumn("dbo.FormatManagers", "Age");
            DropColumn("dbo.DepartmentManagers", "Age");
            CreateIndex("dbo.RegionalManagers", "MarketId");
            CreateIndex("dbo.FormatManagers", "RegionalManagerId");
            CreateIndex("dbo.DepartmentManagers", "FormatManagerId");
        }
    }
}
