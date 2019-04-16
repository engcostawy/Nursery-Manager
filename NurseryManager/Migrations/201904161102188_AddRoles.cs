namespace NurseryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoles : DbMigration
    {
        public override void Up()
        {
            Sql("insert into AspNetRoles(Id,Name) values (1,'Free')");
            Sql("insert into AspNetRoles(Id,Name) values (2,'Subscribe')");
            Sql("insert into AspNetRoles(Id,Name) values (3,'User')");
            Sql("insert into AspNetRoles(Id,Name) values (4,'Admin')");
        }
        
        public override void Down()
        {
        }
    }
}
