namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilkl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Yazars", "YazarEmailAdresi", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yazars", "YazarEmailAdresi", c => c.String());
        }
    }
}
