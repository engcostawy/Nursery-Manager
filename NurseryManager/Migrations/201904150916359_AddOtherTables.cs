namespace NurseryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOtherTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactNumbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactName = c.String(),
                        PhoneNumber = c.String(),
                        ContactId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .Index(t => t.ContactId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Facebook = c.String(),
                        Instagram = c.String(),
                        Website = c.String(),
                        NurseryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nurseries", t => t.NurseryId, cascadeDelete: true)
                .Index(t => t.NurseryId);
            
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Water = c.String(),
                        Milk = c.String(),
                        Date = c.DateTime(nullable: false),
                        ChildId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.ChildId, cascadeDelete: true)
                .Index(t => t.ChildId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        Description = c.String(),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        ClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Breakfast = c.String(),
                        Launch = c.String(),
                        Dinner = c.String(),
                        Snack = c.String(),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        ChildId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.ChildId, cascadeDelete: true)
                .Index(t => t.ChildId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        ClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Hygines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Stool = c.Int(nullable: false),
                        Pee = c.Int(nullable: false),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        ChildId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.ChildId, cascadeDelete: true)
                .Index(t => t.ChildId);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        Date = c.DateTime(nullable: false),
                        ChildId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.ChildId, cascadeDelete: true)
                .Index(t => t.ChildId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Breakfast = c.String(),
                        Launch = c.String(),
                        Dinner = c.String(),
                        Snack = c.String(),
                        Day = c.Int(nullable: false),
                        ClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Moods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChildMood = c.String(),
                        Date = c.DateTime(nullable: false),
                        ChildId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.ChildId, cascadeDelete: true)
                .Index(t => t.ChildId);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        ChildId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.ChildId, cascadeDelete: true)
                .Index(t => t.ChildId);
            
            CreateTable(
                "dbo.Sleeps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        ChildId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.ChildId, cascadeDelete: true)
                .Index(t => t.ChildId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sleeps", "ChildId", "dbo.Children");
            DropForeignKey("dbo.Notes", "ChildId", "dbo.Children");
            DropForeignKey("dbo.Moods", "ChildId", "dbo.Children");
            DropForeignKey("dbo.Menus", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Images", "ChildId", "dbo.Children");
            DropForeignKey("dbo.Hygines", "ChildId", "dbo.Children");
            DropForeignKey("dbo.Galleries", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Foods", "ChildId", "dbo.Children");
            DropForeignKey("dbo.Events", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Drinks", "ChildId", "dbo.Children");
            DropForeignKey("dbo.ContactNumbers", "ContactId", "dbo.Contacts");
            DropForeignKey("dbo.Contacts", "NurseryId", "dbo.Nurseries");
            DropIndex("dbo.Sleeps", new[] { "ChildId" });
            DropIndex("dbo.Notes", new[] { "ChildId" });
            DropIndex("dbo.Moods", new[] { "ChildId" });
            DropIndex("dbo.Menus", new[] { "ClassId" });
            DropIndex("dbo.Images", new[] { "ChildId" });
            DropIndex("dbo.Hygines", new[] { "ChildId" });
            DropIndex("dbo.Galleries", new[] { "ClassId" });
            DropIndex("dbo.Foods", new[] { "ChildId" });
            DropIndex("dbo.Events", new[] { "ClassId" });
            DropIndex("dbo.Drinks", new[] { "ChildId" });
            DropIndex("dbo.Contacts", new[] { "NurseryId" });
            DropIndex("dbo.ContactNumbers", new[] { "ContactId" });
            DropTable("dbo.Sleeps");
            DropTable("dbo.Notes");
            DropTable("dbo.Moods");
            DropTable("dbo.Menus");
            DropTable("dbo.Images");
            DropTable("dbo.Hygines");
            DropTable("dbo.Galleries");
            DropTable("dbo.Foods");
            DropTable("dbo.Events");
            DropTable("dbo.Drinks");
            DropTable("dbo.Contacts");
            DropTable("dbo.ContactNumbers");
        }
    }
}
