namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCharacter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        ClassId = c.Byte(nullable: false),
                        Race = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Characters", "ClassId", "dbo.Classes");
            DropIndex("dbo.Characters", new[] { "ClassId" });
            DropTable("dbo.Classes");
            DropTable("dbo.Characters");
        }
    }
}
