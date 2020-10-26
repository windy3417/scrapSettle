namespace ScrapSettlement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WeighingSettlements", "webUnitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.WeighingSettlements", "settleUnitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.WeighingSettlements", "settleAmount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WeighingSettlements", "settleAmount", c => c.Double());
            AlterColumn("dbo.WeighingSettlements", "settleUnitPrice", c => c.Double());
            AlterColumn("dbo.WeighingSettlements", "webUnitPrice", c => c.Double());
        }
    }
}
