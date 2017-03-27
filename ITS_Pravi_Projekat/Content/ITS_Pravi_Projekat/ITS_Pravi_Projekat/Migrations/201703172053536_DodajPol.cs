namespace ITS_Pravi_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajPol : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivPola = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Osobas", "PolId", c => c.Int(nullable: false));
            CreateIndex("dbo.Osobas", "PolId");
            AddForeignKey("dbo.Osobas", "PolId", "dbo.Pols", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Osobas", "PolId", "dbo.Pols");
            DropIndex("dbo.Osobas", new[] { "PolId" });
            DropColumn("dbo.Osobas", "PolId");
            DropTable("dbo.Pols");
        }
    }
}
