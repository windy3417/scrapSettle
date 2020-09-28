namespace ScrapSettlement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recontructMoudle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CusCode = c.Int(nullable: false),
                        CusName = c.String(),
                        EffectDate = c.DateTime(nullable: false),
                        FailuerDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Scraps",
                c => new
                    {
                        ScrapID = c.Int(nullable: false, identity: true),
                        ScrapName = c.String(),
                    })
                .PrimaryKey(t => t.ScrapID);
            
            CreateTable(
                "dbo.WeighingSettlements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vocherNO = c.String(),
                        CustmerCode = c.String(),
                        personCode = c.String(),
                        scrapCode = c.String(),
                        netWeight = c.Double(nullable: false),
                        proportion = c.Double(nullable: false),
                        webUnitPrice = c.Double(nullable: false),
                        settleUnitPrice = c.Double(nullable: false),
                        settleAmount = c.Double(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                        CustomerSet_CustomerID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerSet_CustomerID)
                .Index(t => t.CustomerSet_CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeighingSettlements", "CustomerSet_CustomerID", "dbo.Customers");
            DropIndex("dbo.WeighingSettlements", new[] { "CustomerSet_CustomerID" });
            DropTable("dbo.WeighingSettlements");
            DropTable("dbo.Scraps");
            DropTable("dbo.Customers");
        }
    }
}
