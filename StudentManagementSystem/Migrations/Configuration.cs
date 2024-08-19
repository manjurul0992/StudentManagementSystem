namespace StudentManagementSystem.Migrations
{
    using StudentManagementSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentManagementSystem.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentManagementSystem.Data.AppDbContext context)
        {
            context.Students.AddOrUpdate(
                 s => s.StudentName,
                 new Student
                 {
                     StudentName = "Manjurul",
                     BirthDate = new DateTime(2005, 5, 12),
                     Class = "10th",
                     Section = Section.Science
                 },
                 new Student
                 {
                     StudentName = "Syed",
                     BirthDate = new DateTime(2004, 3, 18),
                     Class = "11th",
                     Section = Section.Arts
                 },
                 new Student
                 {
                     StudentName = "Arju",
                     BirthDate = new DateTime(2005, 8, 22),
                     Class = "10th",
                     Section = Section.Commerence
                 },
                 new Student
                 {
                     StudentName = "Brown",
                     BirthDate = new DateTime(2003, 11, 4),
                     Class = "12th",
                     Section = Section.Science
                 }
             );


            base.Seed(context);
        }
    }
}
