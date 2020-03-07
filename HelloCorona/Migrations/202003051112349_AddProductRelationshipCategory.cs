namespace HelloCorona.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductRelationshipCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category_CategoryId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Products", "Category_CategoryId");
            AddForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            DropColumn("dbo.Products", "Category_CategoryId");
        }
    }
}
