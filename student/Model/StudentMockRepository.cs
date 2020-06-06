using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace student.Model
{
    public class StudentMockRepository : IStudentRepository
    {
        private List<Student> _students = new List<Student>()
        {
            new Student()
            {
                Age = 20,
                Id = 1,
                Name = "Json",
                LastName = "Snow"
            },
            new Student()
            {
                Age = 15,
                Id = 2,
                Name = "Rita",
                LastName = "Dark"
            }
        };

        public void CreateStudent(Student student)
        {
            var id = _students.Max(s => s.Id);
            _students.Add(new Student()
            {
                Id = id+1,
                Name = student.Name,
                LastName = student.LastName,
                Age = student.Age
            });
        }

        public void DeleteStudent(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            _students.Remove(student);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }

        public void UpdateStudent(Student student)
        {
            var studentToUpdate = _students.FirstOrDefault(s => s.Id == student.Id);
            var index = _students.IndexOf(studentToUpdate);
            _students[index] = student;
        }
    }
}
