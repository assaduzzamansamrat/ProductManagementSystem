namespace PMSRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewtables : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.Products");
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        EmailAddress = c.String(),
                        CompanyLogo = c.String(),
                        CompanyType = c.String(),
                        CompanyWebsite = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        UserProfileImage = c.String(),
                        Address = c.String(),
                        Role = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Categories", "ProductCategoryDetails", c => c.String());
            AddColumn("dbo.Products", "Unit", c => c.String());
            AddColumn("dbo.Products", "CompanyId", c => c.Long(nullable: false));
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "ProductImageOne", c => c.String());
            AddColumn("dbo.Products", "ProductImageTwo", c => c.String());
            AddColumn("dbo.Products", "ProductImageThree", c => c.String());
            AddColumn("dbo.Products", "ProductImageFour", c => c.String());
            AlterColumn("dbo.Categories", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Products", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Categories", "Id");
            AddPrimaryKey("dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Products");
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Products", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Categories", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Products", "ProductImageFour");
            DropColumn("dbo.Products", "ProductImageThree");
            DropColumn("dbo.Products", "ProductImageTwo");
            DropColumn("dbo.Products", "ProductImageOne");
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Products", "CompanyId");
            DropColumn("dbo.Products", "Unit");
            DropColumn("dbo.Categories", "ProductCategoryDetails");
            DropTable("dbo.Users");
            DropTable("dbo.Companies");
            AddPrimaryKey("dbo.Products", "Id");
            AddPrimaryKey("dbo.Categories", "Id");
        }
    }
}
