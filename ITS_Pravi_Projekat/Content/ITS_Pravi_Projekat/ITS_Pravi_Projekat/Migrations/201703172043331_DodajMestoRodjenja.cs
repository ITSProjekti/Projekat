namespace ITS_Pravi_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajMestoRodjenja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mestoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NazivMesta = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Osobas", "MestoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Osobas", "MestoId");
            AddForeignKey("dbo.Osobas", "MestoId", "dbo.Mestoes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Osobas", "MestoId", "dbo.Mestoes");
            DropIndex("dbo.Osobas", new[] { "MestoId" });
            DropColumn("dbo.Osobas", "MestoId");
            DropTable("dbo.Mestoes");
        }
    }
}
