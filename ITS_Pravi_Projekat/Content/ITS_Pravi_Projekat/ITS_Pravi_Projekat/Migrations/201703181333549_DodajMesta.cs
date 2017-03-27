namespace ITS_Pravi_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajMesta : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MESTOES(NazivMesta) Values('Beograd')");
            Sql("INSERT INTO MESTOES(NazivMesta) Values('Novi Sad')");
            Sql("INSERT INTO MESTOES(NazivMesta) Values('Nis')");
          
        }
        
        public override void Down()
        {
        }
    }
}
