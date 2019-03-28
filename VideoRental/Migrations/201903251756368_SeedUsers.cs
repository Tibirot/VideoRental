namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'01358e3b-ce84-4dcc-a7df-9e630fb5a308', N'admin2@videorental.com', 0, N'ABKzep4vGTpM0lrowI2OKXtVZzDOBa1Hiw+4rhyyAFtshN4SrgYMFbhV/zDAwmtBZQ==', N'cea770fd-88b5-42ba-9353-388f70498e10', NULL, 0, 0, NULL, 1, 0, N'admin2@videorental.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3be71d6b-4e1a-49ae-be9a-e56143916be0', N'admin@videorental.com', 0, N'ADkNgECTsjle7oHN97kzaGvlwTykUf0SH96i6cRNjZips6AIGoS+U/W2MTf+0DbnjA==', N'3691731c-9227-458e-bba1-397c056bb3ac', NULL, 0, 0, NULL, 1, 0, N'admin@videorental.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ade82406-cf30-40df-93fa-c905496c51f7', N'guest@vidly.com', 0, N'AKrID2GF6a2i3ZTumcXHsltghRe3YU79/tnoVdM2kOx2NY/GcENNki95L1PqEPL0yw==', N'8431e378-571a-4535-bd67-e603a2f3b23d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd5020fae-0e75-419f-9d8d-c08faf1b0c90', N'test@gmail.com', 0, N'ACqzRNF6eeqCTicSpi1D6XmqMTXVzXWGX5WXQ+gXc3UPauenpboiSbVKdoDE0veSng==', N'b0807a90-5e98-4cd7-9047-e45f60a539d6', NULL, 0, 0, NULL, 1, 0, N'test@gmail.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9d345f1d-59d1-40c9-8c67-3aedce6ed4ac', N'CanManageMovies')
                        
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'01358e3b-ce84-4dcc-a7df-9e630fb5a308', N'9d345f1d-59d1-40c9-8c67-3aedce6ed4ac')
                    ");
        }
        
        public override void Down()
        {
        }
    }
}
