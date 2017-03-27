namespace ITS_Pravi_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PonovoPopuniPol : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO POLS(NazivPola) VALUES ('Muski')");
            Sql("INSERT INTO POLS(NazivPola) VALUES ('Zenski')");


        }

        public override void Down()
        {
        }
    }
}
