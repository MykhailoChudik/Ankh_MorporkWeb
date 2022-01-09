namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalDataBaseV20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Thieves", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "Beer", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Beer");
            DropColumn("dbo.Players", "Thieves");
        }
    }
}
