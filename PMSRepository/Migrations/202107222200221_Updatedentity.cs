namespace PMSRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CompanyId", c => c.Long(nullable: false));
            AddColumn("dbo.Categories", "CreatedBy", c => c.Long(nullable: false));
            AddColumn("dbo.Categories", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Categories", "EditedBy", c => c.Long(nullable: false));
            AddColumn("dbo.Categories", "EditedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Categories", "IpAddress", c => c.String());
            AddColumn("dbo.Companies", "CreatedBy", c => c.Long(nullable: false));
            AddColumn("dbo.Companies", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Companies", "EditedBy", c => c.Long(nullable: false));
            AddColumn("dbo.Companies", "EditedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Companies", "IpAddress", c => c.String());
            AddColumn("dbo.Products", "CreatedBy", c => c.Long(nullable: false));
            AddColumn("dbo.Products", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "EditedBy", c => c.Long(nullable: false));
            AddColumn("dbo.Products", "EditedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "IpAddress", c => c.String());
            AddColumn("dbo.Users", "CreatedBy", c => c.Long(nullable: false));
            AddColumn("dbo.Users", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "EditedBy", c => c.Long(nullable: false));
            AddColumn("dbo.Users", "EditedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "IpAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IpAddress");
            DropColumn("dbo.Users", "EditedDate");
            DropColumn("dbo.Users", "EditedBy");
            DropColumn("dbo.Users", "CreatedDate");
            DropColumn("dbo.Users", "CreatedBy");
            DropColumn("dbo.Products", "IpAddress");
            DropColumn("dbo.Products", "EditedDate");
            DropColumn("dbo.Products", "EditedBy");
            DropColumn("dbo.Products", "CreatedDate");
            DropColumn("dbo.Products", "CreatedBy");
            DropColumn("dbo.Companies", "IpAddress");
            DropColumn("dbo.Companies", "EditedDate");
            DropColumn("dbo.Companies", "EditedBy");
            DropColumn("dbo.Companies", "CreatedDate");
            DropColumn("dbo.Companies", "CreatedBy");
            DropColumn("dbo.Categories", "IpAddress");
            DropColumn("dbo.Categories", "EditedDate");
            DropColumn("dbo.Categories", "EditedBy");
            DropColumn("dbo.Categories", "CreatedDate");
            DropColumn("dbo.Categories", "CreatedBy");
            DropColumn("dbo.Categories", "CompanyId");
        }
    }
}
