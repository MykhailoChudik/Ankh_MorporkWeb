namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMigration01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assasins",
                c => new
                    {
                        IdAssassins = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Int(nullable: false),
                        work = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdAssassins);
            
            CreateTable(
                "dbo.Boggards",
                c => new
                    {
                        IdBoggard = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdBoggard);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Boggards");
            DropTable("dbo.Assasins");
        }
    }
}
