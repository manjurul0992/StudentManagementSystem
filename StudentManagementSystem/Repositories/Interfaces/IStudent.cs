using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Repositories.Interfaces
{
    internal interface IStudent : IDisposable
    {
        IEnumerable<Student> GetStudents();
        Student GetBookByID(int studentId);
        void InsertBook(Student student);
        void DeleteBook(int StudentID);
        void UpdateBook(Student Student);
        void Save();
    }
}
