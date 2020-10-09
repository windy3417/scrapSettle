namespace ScrapSettlement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WeighingSettlements", "Customers_CustomerID", "dbo.Customers");
            RenameColumn(table: "dbo.WeighingSettlements", name: "Customers_CustomerID", newName: "Customers_CusCode");
            RenameIndex(table: "dbo.WeighingSettlements", name: "IX_Customers_CustomerID", newName: "IX_Customers_CusCode");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CustomerID", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "CusCode", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "CusCode");
            AddForeignKey("dbo.WeighingSettlements", "Customers_CusCode", "dbo.Customers", "CusCode");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeighingSettlements", "Customers_CusCode", "dbo.Customers");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CusCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "CustomerID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "CustomerID");
            RenameIndex(table: "dbo.WeighingSettlements", name: "IX_Customers_CusCode", newName: "IX_Customers_CustomerID");
            RenameColumn(table: "dbo.WeighingSettlements", name: "Customers_CusCode", newName: "Customers_CustomerID");
            AddForeignKey("dbo.WeighingSettlements", "Customers_CustomerID", "dbo.Customers", "CustomerID");
        }
    }
}
