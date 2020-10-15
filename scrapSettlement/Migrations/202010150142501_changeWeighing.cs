namespace ScrapSettlement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeWeighing : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WeighingSettlements", "Customers_CusCode", "dbo.Customers");
            DropIndex("dbo.WeighingSettlements", new[] { "Customers_CusCode" });
            DropPrimaryKey("dbo.WeighingSettlements");
            AlterColumn("dbo.WeighingSettlements", "vocherNO", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.WeighingSettlements", "vocherNO");
            DropColumn("dbo.WeighingSettlements", "Id");
            DropColumn("dbo.WeighingSettlements", "Customer_Id");
            DropColumn("dbo.WeighingSettlements", "Customers_CusCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WeighingSettlements", "Customers_CusCode", c => c.Int());
            AddColumn("dbo.WeighingSettlements", "Customer_Id", c => c.Int(nullable: false));
            AddColumn("dbo.WeighingSettlements", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.WeighingSettlements");
            AlterColumn("dbo.WeighingSettlements", "vocherNO", c => c.String());
            AddPrimaryKey("dbo.WeighingSettlements", "Id");
            CreateIndex("dbo.WeighingSettlements", "Customers_CusCode");
            AddForeignKey("dbo.WeighingSettlements", "Customers_CusCode", "dbo.Customers", "CusCode");
        }
    }
}
