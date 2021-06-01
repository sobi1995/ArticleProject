using Course.Microservice.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Microservice.Model.Services
{
public   interface ICourseRepository
    {
        CourseEntity GetCourse(int? CourseId);
        List<CourseEntity> GetAll();
        int AddCourse(CourseEntity model); 
        int DeleteCourse(int? CourseId);
        Task UpdateCourse(CourseEntity model);
       
    }
}
