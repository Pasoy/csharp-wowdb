namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClasses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Classes (Id, Name) VALUES (1, 'Death Knight')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (2, 'Demon Hunter')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (3, 'Druid')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (4, 'Hunter')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (5, 'Mage')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (6, 'Monk')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (7, 'Paladin')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (8, 'Priest')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (9, 'Rogue')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (10, 'Shaman')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (11, 'Warlock')");
            Sql("INSERT INTO Classes (Id, Name) VALUES (12, 'Warrior')");
        }
        
        public override void Down()
        {
        }
    }
}
