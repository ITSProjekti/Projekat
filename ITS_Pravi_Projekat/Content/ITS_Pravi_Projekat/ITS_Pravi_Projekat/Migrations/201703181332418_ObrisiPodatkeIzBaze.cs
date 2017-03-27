namespace ITS_Pravi_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ObrisiPodatkeIzBaze : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM MESTOES");
            Sql("DELETE FROM OSOBAS");
            Sql("DELETE FROM POLS");
        }
        
        public override void Down()
        {
        }
    }
}
