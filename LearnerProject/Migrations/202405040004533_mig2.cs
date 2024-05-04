namespace LearnerProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.Reviews", new[] { "Course_CourseId" });
            DropColumn("dbo.Reviews", "CourseId");
            RenameColumn(table: "dbo.Reviews", name: "Course_CourseId", newName: "CourseId");
            AlterColumn("dbo.Reviews", "CourseId", c => c.Int(nullable: false));
            AlterColumn("dbo.Reviews", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "CourseId");
            AddForeignKey("dbo.Reviews", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "CourseId", "dbo.Courses");
            DropIndex("dbo.Reviews", new[] { "CourseId" });
            AlterColumn("dbo.Reviews", "CourseId", c => c.Int());
            AlterColumn("dbo.Reviews", "CourseId", c => c.String());
            RenameColumn(table: "dbo.Reviews", name: "CourseId", newName: "Course_CourseId");
            AddColumn("dbo.Reviews", "CourseId", c => c.String());
            CreateIndex("dbo.Reviews", "Course_CourseId");
            AddForeignKey("dbo.Reviews", "Course_CourseId", "dbo.Courses", "CourseId");
        }
    }
}
