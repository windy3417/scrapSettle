namespace ScrapSettlement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coefficients",
                c => new
                    {
                        VoucherNO = c.String(nullable: false, maxLength: 128),
                        CoefficientID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        ScrapID = c.Int(nullable: false),
                        Data = c.Double(nullable: false),
                        EffectDate = c.DateTime(nullable: false),
                        FailureDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.VoucherNO);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CusCode = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false, identity: true),
                        CusName = c.String(),
                        EffectDate = c.DateTime(nullable: false),
                        FailuerDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.CusCode);
            
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        VoucherNo = c.String(nullable: false, maxLength: 128),
                        CustormerID = c.Int(nullable: false),
                        Money = c.Double(nullable: false),
                        IncomeDate = c.DateTime(nullable: false),
                        MakeDte = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VoucherNo);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EffectDate = c.DateTime(nullable: false),
                        FailuerDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Scraps",
                c => new
                    {
                        ScrapCode = c.Int(nullable: false),
                        ScrapID = c.Int(nullable: false, identity: true),
                        ScrapName = c.String(),
                        EffectDate = c.DateTime(nullable: false),
                        FailuerDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ScrapCode);
            
            CreateTable(
                "dbo.VehicleBrands",
                c => new
                    {
                        VehicleBrandValue = c.String(nullable: false, maxLength: 128),
                        CustomerID = c.Int(nullable: false),
                        EffectDate = c.DateTime(nullable: false),
                        FailuerDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.VehicleBrandValue);
            
            CreateTable(
                "dbo.WeighingSettlements",
                c => new
                    {
                        vocherNO = c.String(nullable: false, maxLength: 128),
                        MakeDate = c.DateTime(nullable: false),
                        WeighingDate = c.DateTime(nullable: false),
                        CustmerCode = c.String(),
                        personCode = c.String(),
                        scrapCode = c.String(),
                        GrossWeght = c.Double(nullable: false),
                        Tare = c.Double(nullable: false),
                        VehicleBrand = c.String(),
                        netWeight = c.Double(nullable: false),
                        proportion = c.Double(nullable: false),
                        webUnitPrice = c.Double(nullable: false),
                        settleUnitPrice = c.Double(nullable: false),
                        settleAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.vocherNO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WeighingSettlements");
            DropTable("dbo.VehicleBrands");
            DropTable("dbo.Scraps");
            DropTable("dbo.People");
            DropTable("dbo.Incomes");
            DropTable("dbo.Customers");
            DropTable("dbo.Coefficients");
        }
    }
}
