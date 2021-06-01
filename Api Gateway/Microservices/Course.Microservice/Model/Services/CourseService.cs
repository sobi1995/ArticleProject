using Course.Microservice.Model.Context;
using Course.Microservice.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Microservice.Model.Services
{
     public class CourseRepository : ICourseRepository
    {

        private List<CourseEntity> courses;
        public CourseRepository()
        {
            courses = new List<CourseEntity>();
            
        }

        public int AddCourse(CourseEntity model)
        {
            courses.Add(model);
            return 1;
        }

        public int DeleteCourse(int? CourseId)
        {
            throw new NotImplementedException();
        }

        public List<CourseEntity> GetAll()
        {
            return courses;
        }

        public CourseEntity GetCourse(int? CourseId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourse(CourseEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
