namespace ScrapSettlement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WeighingSettlements", "auditFlag", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeighingSettlements", "auditFlag");
        }
    }
}
