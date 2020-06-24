namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'73c5facc-8db8-4f70-afee-ebefc8ab5c67', N'guest@wow.com', 0, N'ALYq9dnMUK4wh9OC1J1QwxURknBPWNZDGue+k4aKkS+9B9OLuv8W9C1K6bFJOHaCAw==', N'd06425b3-dde0-4f05-9f64-747d5d6f9da6', NULL, 0, 0, NULL, 1, 0, N'guest@wow.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'96efcda2-4322-4550-a748-70e0908a960a', N'admin@wow.com', 0, N'AJp/SXX9LIdW1aPfEJhi6VjptY+zlThvX3anA0FAXFgmKCkjebouT5b8J3SDoQcRFQ==', N'b8c3196d-e0e6-49be-bbc6-1d302a87af5b', NULL, 0, 0, NULL, 1, 0, N'admin@wow.com')
                
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'58b103db-7d5e-4f30-bb87-86e26b6553ec', N'CanManageCharacters')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'96efcda2-4322-4550-a748-70e0908a960a', N'58b103db-7d5e-4f30-bb87-86e26b6553ec')

");
        }
        
        public override void Down()
        {
        }
    }
}
