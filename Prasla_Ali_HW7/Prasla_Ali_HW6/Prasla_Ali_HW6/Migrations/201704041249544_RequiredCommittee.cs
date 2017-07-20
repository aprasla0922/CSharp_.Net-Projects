namespace Prasla_Ali_HW6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredCommittee : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "Committee_CommitteeID", "dbo.Committees");
            DropIndex("dbo.Events", new[] { "Committee_CommitteeID" });
            AlterColumn("dbo.Events", "Committee_CommitteeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "Committee_CommitteeID");
            AddForeignKey("dbo.Events", "Committee_CommitteeID", "dbo.Committees", "CommitteeID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Committee_CommitteeID", "dbo.Committees");
            DropIndex("dbo.Events", new[] { "Committee_CommitteeID" });
            AlterColumn("dbo.Events", "Committee_CommitteeID", c => c.Int());
            CreateIndex("dbo.Events", "Committee_CommitteeID");
            AddForeignKey("dbo.Events", "Committee_CommitteeID", "dbo.Committees", "CommitteeID");
        }
    }
}
