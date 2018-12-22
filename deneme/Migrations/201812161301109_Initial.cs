namespace deneme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DepartmentManagers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FormatManagerId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Surname = c.String(nullable: false, maxLength: 20),
                        FatherName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FormatManagers", t => t.FormatManagerId, cascadeDelete: true)
                .Index(t => t.FormatManagerId);
            
            CreateTable(
                "dbo.FormatManagers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegionalManagerId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Surname = c.String(nullable: false, maxLength: 20),
                        FatherName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RegionalManagers", t => t.RegionalManagerId, cascadeDelete: true)
                .Index(t => t.RegionalManagerId);
            
            CreateTable(
                "dbo.RegionalManagers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarketId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Surname = c.String(nullable: false, maxLength: 20),
                        FatherName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markets", t => t.MarketId, cascadeDelete: true)
                .Index(t => t.MarketId);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Adress = c.String(nullable: false, maxLength: 40),
                        Manager = c.String(nullable: false, maxLength: 20),
                        Type = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Lat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lon = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Byte(nullable: false),
                        VehicleNumber = c.String(nullable: false),
                        RTcode = c.String(nullable: false),
                        TravelExpenses = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Surname = c.String(nullable: false, maxLength: 20),
                        FatherName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Negatives",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        State = c.String(nullable: false),
                        Point = c.Byte(nullable: false),
                        Comments = c.String(nullable: false),
                        PhotoPath = c.String(),
                        AudioPath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkerMarkets",
                c => new
                    {
                        Worker_Id = c.Int(nullable: false),
                        Market_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Worker_Id, t.Market_Id })
                .ForeignKey("dbo.Workers", t => t.Worker_Id, cascadeDelete: true)
                .ForeignKey("dbo.Markets", t => t.Market_Id, cascadeDelete: true)
                .Index(t => t.Worker_Id)
                .Index(t => t.Market_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DepartmentManagers", "FormatManagerId", "dbo.FormatManagers");
            DropForeignKey("dbo.FormatManagers", "RegionalManagerId", "dbo.RegionalManagers");
            DropForeignKey("dbo.RegionalManagers", "MarketId", "dbo.Markets");
            DropForeignKey("dbo.WorkerMarkets", "Market_Id", "dbo.Markets");
            DropForeignKey("dbo.WorkerMarkets", "Worker_Id", "dbo.Workers");
            DropForeignKey("dbo.Markets", "LocationId", "dbo.Locations");
            DropIndex("dbo.WorkerMarkets", new[] { "Market_Id" });
            DropIndex("dbo.WorkerMarkets", new[] { "Worker_Id" });
            DropIndex("dbo.Markets", new[] { "LocationId" });
            DropIndex("dbo.RegionalManagers", new[] { "MarketId" });
            DropIndex("dbo.FormatManagers", new[] { "RegionalManagerId" });
            DropIndex("dbo.DepartmentManagers", new[] { "FormatManagerId" });
            DropTable("dbo.WorkerMarkets");
            DropTable("dbo.Negatives");
            DropTable("dbo.Workers");
            DropTable("dbo.Locations");
            DropTable("dbo.Markets");
            DropTable("dbo.RegionalManagers");
            DropTable("dbo.FormatManagers");
            DropTable("dbo.DepartmentManagers");
        }
    }
}
