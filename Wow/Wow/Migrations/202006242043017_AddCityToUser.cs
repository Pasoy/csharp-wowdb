namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCityToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "City", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "City");
        }
    }
}
