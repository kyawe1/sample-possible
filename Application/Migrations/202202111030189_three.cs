namespace Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class three : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Product_Price", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Product_Price", c => c.String());
        }
    }
}
