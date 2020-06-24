namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRaces2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (1, 'Human', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (2, 'Worgen', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (3, 'Kul Tiran', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (4, 'Night Elf', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (5, 'Void Elf', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (6, 'Dwarf', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (7, 'Draenei', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (8, 'Gnome', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (9, 'Lightforged Draenei', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (10, 'Lightforged Draenei', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (11, 'Mechagnome', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (12, 'Dark Iron Dwarf', 1)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (13, 'Pandaren', 3)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (14, 'Blood Elf', 2)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (15, 'Orc', 2)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (16, 'Vulpera', 2)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (17, 'Tauren', 2)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (18, 'Zandalari Troll', 2)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (19, 'Troll', 2)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (20, 'Highmountain Troll', 2)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (21, 'Goblin', 2)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (22, 'Undead', 2)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (23, 'Nightborne', 2)");
            Sql("INSERT INTO Races (Id, Name, SideId) VALUES (24, 'Maghar Orc', 2)");
        }
        
        public override void Down()
        {
        }
    }
}
