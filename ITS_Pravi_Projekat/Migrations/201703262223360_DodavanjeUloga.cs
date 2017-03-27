namespace ITS_Pravi_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodavanjeUloga : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'28faf08f-d354-4f80-826e-21775d6c9d9c', N'Admin@ITS_Projekat.com', 0, N'AM/qwa48GnvRnBd2iO0/14j1Rsm5QTcDcPWlLxz8Vq5Bm3TydheyODXYKsj2rCQ9kQ==', N'30aaf2ee-44a0-41a3-83aa-172b5d58488d', NULL, 0, 0, NULL, 1, 0, N'Admin@ITS_Projekat.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'669e4f5f-8770-42bd-8c35-3fcf6d9262ee', N'Korisnik@korisnik.com', 0, N'AEGEcVESK+6rO1jG6nK+3N+Z9sLESfT7T4ld2CiZdWdzLQgm9CG5pl7EGXqsWzs63Q==', N'60a36c9a-0242-41f9-9dae-1bd178c5e491', NULL, 0, 0, NULL, 1, 0, N'Korisnik@korisnik.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'84f9ed98-ccaf-4378-93af-867c8c2ea2f3', N'gost@generic.com', 0, N'AHlDkFbUbgm/FH4omlHeCbrgeafn6rbGvl+prB43e6FSyPsIy6aUKiUlrASVNZpF6A==', N'02e5add7-50d3-44b6-bbff-1d28c1025e0c', NULL, 0, 0, NULL, 1, 0, N'gost@generic.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'58dc0174-7885-41ae-82d2-5f04abf73283', N'MenjaDodajeStampaOsobuRegistrujeKorisnike')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0989fc18-7423-4701-a129-76aa405b3e10', N'PrikazujeStampaIDodajeOsobu')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'669e4f5f-8770-42bd-8c35-3fcf6d9262ee', N'0989fc18-7423-4701-a129-76aa405b3e10')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'28faf08f-d354-4f80-826e-21775d6c9d9c', N'58dc0174-7885-41ae-82d2-5f04abf73283')

");

        }

        public override void Down()
        {
        }
    }
}
