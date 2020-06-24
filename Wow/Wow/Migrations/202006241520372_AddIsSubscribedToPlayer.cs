namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToPlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "IsSubscribed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "IsSubscribed");
        }
    }
}
