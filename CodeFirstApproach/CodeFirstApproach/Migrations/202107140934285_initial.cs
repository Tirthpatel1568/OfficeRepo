namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityID);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateID = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.StateID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        StateID = c.Int(nullable: false),
                        CityID = c.Int(nullable: false),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.StateID, cascadeDelete: true)
                .Index(t => t.StateID)
                .Index(t => t.CityID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "StateID", "dbo.States");
            DropForeignKey("dbo.Students", "CityID", "dbo.Cities");
            DropIndex("dbo.Students", new[] { "CityID" });
            DropIndex("dbo.Students", new[] { "StateID" });
            DropTable("dbo.Students");
            DropTable("dbo.States");
            DropTable("dbo.Cities");
        }
    }
}
