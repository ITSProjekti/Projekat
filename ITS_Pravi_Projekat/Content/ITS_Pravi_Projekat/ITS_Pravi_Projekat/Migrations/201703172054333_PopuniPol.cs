namespace ITS_Pravi_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopuniPol : DbMigration
    {
        public override void Up()
        {
            Sql(" INSERT INTO Pols(NazivPola) VALUES ('Muski') ");
            Sql(" INSERT INTO Pols(NazivPola) VALUES ('Zenski') ");
        }
        
        public override void Down()
        {
        }
    }
}
