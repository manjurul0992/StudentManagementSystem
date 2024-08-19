using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Repositories.Implementation
{
    public class StudentRepository : IStudent
    {
        
        private bool disposed = false;
        private AppDbContext _context;
        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        void IStudent.DeleteBook(int StudentID)
        {
            Student book = _context.Students.Find(StudentID);
            _context.Students.Remove(book);
        }

        Student IStudent.GetBookByID(int studentId)
        {
            return _context.Students.Find(studentId);
        }

        IEnumerable<Student> IStudent.GetStudents()
        {
            return _context.Students.ToList();
        }

        void IStudent.InsertBook(Student student)
        {
            _context.Students.Add(student);
        }

        void IStudent.Save()
        {
            _context.SaveChanges();
        }

        void IStudent.UpdateBook(Student Student)
        {
            _context.Entry(Student).State = EntityState.Modified;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        

        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}