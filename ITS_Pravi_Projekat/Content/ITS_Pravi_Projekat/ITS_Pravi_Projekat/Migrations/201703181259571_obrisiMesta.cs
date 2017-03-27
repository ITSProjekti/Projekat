namespace ITS_Pravi_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class obrisiMesta : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM MESTOES");
        }
        
        public override void Down()
        {
        }
    }
}
