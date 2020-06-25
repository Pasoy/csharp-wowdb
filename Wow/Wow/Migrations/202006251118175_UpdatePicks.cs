namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePicks : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Picks", name: "Character_Id", newName: "CharacterId");
            RenameColumn(table: "dbo.Picks", name: "Player_Id", newName: "PlayerId");
            RenameIndex(table: "dbo.Picks", name: "IX_Player_Id", newName: "IX_PlayerId");
            RenameIndex(table: "dbo.Picks", name: "IX_Character_Id", newName: "IX_CharacterId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Picks", name: "IX_CharacterId", newName: "IX_Character_Id");
            RenameIndex(table: "dbo.Picks", name: "IX_PlayerId", newName: "IX_Player_Id");
            RenameColumn(table: "dbo.Picks", name: "PlayerId", newName: "Player_Id");
            RenameColumn(table: "dbo.Picks", name: "CharacterId", newName: "Character_Id");
        }
    }
}
