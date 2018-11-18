namespace ContosoUniversity.Web.DataContexts.UniversityMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "University.Course",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Title = c.String(maxLength: 50),
                        Credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "University.Enrollment",
                c => new
                    {
                        EnrollmentId = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.EnrollmentId)
                .ForeignKey("University.Course", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("University.Student", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "University.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 255),
                        LastName = c.String(maxLength: 255),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("University.Enrollment", "StudentId", "University.Student");
            DropForeignKey("University.Enrollment", "CourseId", "University.Course");
            DropIndex("University.Enrollment", new[] { "StudentId" });
            DropIndex("University.Enrollment", new[] { "CourseId" });
            DropTable("University.Student");
            DropTable("University.Enrollment");
            DropTable("University.Course");
        }
    }
}
