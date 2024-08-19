using PagedList;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Implementation;
using StudentManagementSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class StudentsController : Controller
    {
        private IStudent _student;
        public StudentsController()
        {
            this._student = new StudentRepository(new AppDbContext());
        }
        // GET: Students
        public ActionResult Index(int page = 1)
        {
            var students = from book in _student.GetStudents()
                        select book;
            var one = students.OrderBy(x => x.StudentId).ToPagedList(page, 5);
            return View(one);
        }
        
        public ActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _student.InsertBook(student);
                    _student.Save();
                    TempData["SuccessMessage"] = "Student created successfully!";
                    TempData["ShowData"] = "And Data Contain in the Last Page!";

                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                TempData["ErrorMessage"] = "Unable to save changes. Please try again.";
            }

            return View(student);
        }
        public ActionResult Edit(int id)
        {
            Student student = _student.GetBookByID(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _student.UpdateBook(student);
                    _student.Save();
                    TempData["Edit"] = "Student Updated successfully!";

                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                TempData["ErrorMessage"] = "Unable to Update changes. Please try again.";

            }
            return View(student);
        }
        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }

            Student student = _student.GetBookByID(id);
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Student student = _student.GetBookByID(id);
                _student.DeleteBook(id);
                _student.Save();
                TempData["Delete"] = "Student Deleted successfully!";

            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new System.Web.Routing.RouteValueDictionary

        {
            { "id", id },
            { "saveChangesError", true }
        });

            }

            return RedirectToAction("Index");
        }
    }
}