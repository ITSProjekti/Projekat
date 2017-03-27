namespace ITS_Pravi_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopuniGradove : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MESTOES (NazivMesta) VALUES('Beograd')");
            Sql("INSERT INTO MESTOES (NazivMesta) VALUES('Novi Sad')");
            Sql("INSERT INTO MESTOES (NazivMesta) VALUES('Subotica')");
        }
        
        public override void Down()
        {
        }
    }
}
