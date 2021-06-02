 
using Course.Microservice.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Microservice.Model.Services
{
     public class StudentRepository : IStudentRepository
    {

        private List<StudentEntity> students;
        public StudentRepository()
        {
            students = new List<StudentEntity>();
            
        }

        public int AddCourse(StudentEntity model)
        {
            students.Add(model);
            return 1;
        }

        public int DeleteCourse(int? CourseId)
        {
            throw new NotImplementedException();
        }

        public List<StudentEntity> GetAll()
        {
            return students;
        }

        public StudentEntity GetCourse(int? CourseId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourse(StudentEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
