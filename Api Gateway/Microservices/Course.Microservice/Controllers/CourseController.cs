using Course.Microservice.Model.Entity;
using Course.Microservice.Model.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Microservice.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        readonly private ICourseRepository _courseService;
        public CourseController(ICourseRepository courseService)
        {
            _courseService = courseService;

        }

        [HttpGet]
        public async Task<IActionResult> GetCourse(int? CourseId)
        {
            if (CourseId == null)
            {
                return BadRequest();
            }

            try
            {
                var Course =   _courseService.GetCourse(CourseId);

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
            
         var course = _courseService.GetAll();

            return Ok(course);
        }

        [HttpPost]
        public async Task<IActionResult> AddCourse( CourseEntity model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var CourseId =   _courseService.AddCourse(model);
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

        [HttpDelete]
        public async Task<IActionResult> DeleteCourse(int? CourseId)
        {
            int result = 0;

            if (CourseId == null)
            {
                return BadRequest();
            }

            try
            {
                result =   _courseService.DeleteCourse(CourseId);
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
        public async Task<IActionResult> UpdateCourse([FromBody] Model.Entity.CourseEntity model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _courseService.UpdateCourse(model);

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
