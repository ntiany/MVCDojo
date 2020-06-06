using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using student.Model;

namespace student.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            var students = _studentRepository.GetStudents();
            return View(students);
        }

        public IActionResult Delete(int id)
        {
            _studentRepository.DeleteStudent(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            _studentRepository.CreateStudent(student);
            return RedirectToAction("Index");
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
            _studentRepository.UpdateStudent(student);
            return RedirectToAction("Index");
        }
    }
}
