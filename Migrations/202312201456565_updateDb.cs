namespace MvcPureHtml.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDb : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employee", "CPwd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee", "CPwd", c => c.String(nullable: false));
        }
    }
}
