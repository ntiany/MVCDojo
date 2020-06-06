using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace student.Model
{
    public class StudentMockRepository : IStudentRepository
    {
        private IEnumerable<Student> students = new List<Student>()
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

        public IEnumerable<Student> GetStudents()
        {
            return students;
        }
    }
}
