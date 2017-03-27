namespace ITS_Pravi_Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodajRequieredNaImePrezime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Osobas", "Ime", c => c.String(nullable: false));
            AlterColumn("dbo.Osobas", "Prezime", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Osobas", "Prezime", c => c.String());
            AlterColumn("dbo.Osobas", "Ime", c => c.String());
        }
    }
}
