using Course.Microservice.Model.Entity;
using Course.Microservice.Model.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        readonly private IStudentRepository _studentService;
        public StudentController(IStudentRepository courseService)
        {
            _studentService = courseService;

        }

        [HttpGet("{courseId}")]
        public async Task<IActionResult> GetCourse(int? courseId)
        {
            if (courseId == null)
            {
                return BadRequest();
            }

            try
            {
                var Course =   _studentService.GetCourse(courseId);

                if (Course == null)
                {
                    return NotFound();
                }

                return Ok(Course);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            
         var course = _studentService.GetAll();

            return Ok(course);
        }

        [HttpPost]
        public async Task<IActionResult> AddCourse( StudentEntity model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var CourseId =   _studentService.AddCourse(model);
                    if (CourseId > 0)
                    {
                        return Ok(CourseId);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }
     
        [HttpDelete("{CourseId}")]
        public async Task<IActionResult> DeleteCourse(int? courseId)
        {
            int result = 0;

            if (courseId == null)
            {
                return BadRequest();
            }

            try
            {
                result =   _studentService.DeleteCourse(courseId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateCourse([FromBody]  StudentEntity model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _studentService.UpdateCourse(model);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }
    }
}
