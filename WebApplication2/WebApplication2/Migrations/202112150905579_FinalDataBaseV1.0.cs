namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalDataBaseV10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beggaries",
                c => new
                    {
                        IdBeggary = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdBeggary);
            
            CreateTable(
                "dbo.Fools",
                c => new
                    {
                        IdFools = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdFools);
            
            AddColumn("dbo.Assasins", "MinPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Assasins", "MaxPrice", c => c.Int(nullable: false));
            AlterColumn("dbo.Assasins", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Assasins", "price");
            DropTable("dbo.Boggards");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Boggards",
                c => new
                    {
                        IdBoggard = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Int(nullable: false),
                        adress = c.String(),
                    })
                .PrimaryKey(t => t.IdBoggard);
            
            AddColumn("dbo.Assasins", "price", c => c.Int(nullable: false));
            AlterColumn("dbo.Assasins", "Name", c => c.String());
            DropColumn("dbo.Assasins", "MaxPrice");
            DropColumn("dbo.Assasins", "MinPrice");
            DropTable("dbo.Fools");
            DropTable("dbo.Beggaries");
        }
    }
}
