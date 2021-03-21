namespace TaskElreefelmasry2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Booklets",
                c => new
                    {
                        BookletID = c.Int(nullable: false, identity: true),
                        Activity = c.Int(nullable: false),
                        BookletStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookletID);
            
            CreateTable(
                "dbo.BookletSales",
                c => new
                    {
                        Serial = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CustomerID = c.String(),
                        CustomerName = c.String(),
                        BookletID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Serial)
                .ForeignKey("dbo.Booklets", t => t.BookletID, cascadeDelete: true)
                .Index(t => t.BookletID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookletSales", "BookletID", "dbo.Booklets");
            DropIndex("dbo.BookletSales", new[] { "BookletID" });
            DropTable("dbo.BookletSales");
            DropTable("dbo.Booklets");
        }
    }
}
