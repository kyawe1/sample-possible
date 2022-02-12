namespace Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consumers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Consumer_Name = c.String(),
                        Consumer_Address = c.String(),
                        Consumer_Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Employee_Name = c.String(),
                        Employee_Address = c.String(),
                        Employee_Phone = c.String(),
                        Employee_NRC = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enterprises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Entriprise_Name = c.String(),
                        Tax_id = c.String(),
                        PIC = c.String(),
                        registered_address = c.String(),
                        business_address = c.String(),
                        registered_phonenumber = c.String(),
                        business_phonenumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InventoryControls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Outlet_ID = c.String(),
                        Product_ID = c.String(),
                        Quentity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order_ID = c.String(),
                        Product_ID = c.String(),
                        Quentity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order_ID = c.String(),
                        Employee_ID = c.String(),
                        Consumer_ID = c.String(),
                        Payment_ID = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Outlets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Outlet_Name = c.String(),
                        Outlet_Address = c.String(),
                        Platform = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Payment_Name = c.String(),
                        Payment_Description = c.String(),
                        Payment_Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Name = c.String(),
                        Product_Description = c.String(),
                        Product_Price = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Payments");
            DropTable("dbo.Outlets");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.InventoryControls");
            DropTable("dbo.Enterprises");
            DropTable("dbo.Employees");
            DropTable("dbo.Consumers");
        }
    }
}
