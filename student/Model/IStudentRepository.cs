﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace student.Model
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetStudents();

        public void UpdateStudent(Student student);

        public void CreateStudent(Student student);

        public void DeleteStudent(int id);
    }
}
