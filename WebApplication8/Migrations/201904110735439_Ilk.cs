namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yazars", "YazarEmailAdresi", c => c.String());
            AlterColumn("dbo.Yazars", "YazarAdiSoyadi", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yazars", "YazarAdiSoyadi", c => c.String());
            DropColumn("dbo.Yazars", "YazarEmailAdresi");
        }
    }
}
