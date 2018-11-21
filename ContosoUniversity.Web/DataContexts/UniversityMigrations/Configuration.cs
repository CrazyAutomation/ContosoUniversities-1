using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using ContosoUniversity.Entities;

namespace ContosoUniversity.Web.DataContexts.UniversityMigrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<UniversityDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\UniversityMigrations";
        }

        // This method will be called after migrating to the latest version.
        protected override void Seed(UniversityDb context)
        {
            var students = new List<Student>
            {
                new Student {FirstName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2015-09-01")},
                new Student {FirstName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.Parse("2012-09-01")},
                new Student {FirstName = "Arturo", LastName = "Anand", EnrollmentDate = DateTime.Parse("2013-09-01")},
                new Student {FirstName = "Gytis", LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2012-09-01")},
                new Student {FirstName = "Yan", LastName = "Li", EnrollmentDate = DateTime.Parse("2012-09-01")},
                new Student {FirstName = "Peggy", LastName = "Justice", EnrollmentDate = DateTime.Parse("2011-09-01")},
                new Student {FirstName = "Laura", LastName = "Norman", EnrollmentDate = DateTime.Parse("2013-09-01")},
                new Student {FirstName = "Nino", LastName = "Olivetto", EnrollmentDate = DateTime.Parse("2015-09-01")}
            };

            students.ForEach(s => context.Students.AddOrUpdate(r => new {r.FirstName, r.LastName}, s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course {Code = 1050, Title = "Chemistry", Credits = 3},
                new Course {Code = 4022, Title = "Microeconomics", Credits = 3},
                new Course {Code = 4041, Title = "Macroeconomics", Credits = 3},
                new Course {Code = 1045, Title = "Calculus", Credits = 4},
                new Course {Code = 3141, Title = "Trigonometry", Credits = 4},
                new Course {Code = 2021, Title = "Composition", Credits = 3},
                new Course {Code = 2042, Title = "Literature", Credits = 4}
            };

            courses.ForEach(s => context.Courses.AddOrUpdate(r => new {r.Code, r.Title}, s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment {StudentId = 1, CourseId = 1, Grade = "A"},
                new Enrollment {StudentId = 1, CourseId = 2, Grade = "C"},
                new Enrollment {StudentId = 1, CourseId = 3, Grade = "B"},
                new Enrollment {StudentId = 2, CourseId = 4, Grade = "B"},
                new Enrollment {StudentId = 2, CourseId = 5, Grade = "F"},
                new Enrollment {StudentId = 2, CourseId = 6, Grade = "F"},
                new Enrollment {StudentId = 3, CourseId = 1},
                new Enrollment {StudentId = 4, CourseId = 1},
                new Enrollment {StudentId = 4, CourseId = 2, Grade = "F"},
                new Enrollment {StudentId = 5, CourseId = 3, Grade = "C"},
                new Enrollment {StudentId = 6, CourseId = 4},
                new Enrollment {StudentId = 7, CourseId = 5, Grade = "A"}
            };

            enrollments.ForEach(s => context.Enrollments.AddOrUpdate(r => new {r.StudentId, r.CourseId}, s));
            context.SaveChanges();
        }
    }
}