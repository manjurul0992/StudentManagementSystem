namespace StudentManagementSystem.Migrations
{
    using StudentManagementSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentManagementSystem.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentManagementSystem.Data.AppDbContext context)
        {
            context.Students.Add(new Student
            {
                StudentName = "Test",
                BirthDate = new DateTime(2012, 12, 12),
                Class = "One",
                Section = Section.Science
            });
            

            context.Students.Add(new Student
            {
                StudentName = "Test1",
                BirthDate = new DateTime(2012, 12, 12),
                Class = "Two",
                Section = Section.Arts
            });
            context.SaveChanges();
        }
    }
}
