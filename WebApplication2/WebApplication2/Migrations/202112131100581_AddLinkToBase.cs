namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLinkToBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Boggards", "adress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Boggards", "adress");
        }
    }
}
