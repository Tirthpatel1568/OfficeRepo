namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                    })
                .PrimaryKey(t => t.CourseID);
            
            AddColumn("dbo.Students", "Hobbies", c => c.String());
            AddColumn("dbo.Students", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "CourseID", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "CourseID");
            AddForeignKey("dbo.Students", "CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CourseID", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "CourseID" });
            DropColumn("dbo.Students", "CourseID");
            DropColumn("dbo.Students", "DateOfBirth");
            DropColumn("dbo.Students", "Hobbies");
            DropTable("dbo.Courses");
        }
    }
}
