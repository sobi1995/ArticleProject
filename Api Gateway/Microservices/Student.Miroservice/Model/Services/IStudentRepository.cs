using Course.Microservice.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Microservice.Model.Services
{
public   interface IStudentRepository
    {
        StudentEntity GetCourse(int? CourseId);
        List<StudentEntity> GetAll();
        int AddCourse(StudentEntity model); 
        int DeleteCourse(int? CourseId);
        Task UpdateCourse(StudentEntity model);
       
    }
}
