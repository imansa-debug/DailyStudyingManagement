using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DSM.Application.Interfaces;
using DSM.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DSM.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        //Api/Course
        public IActionResult GetCourses()
        {

            

    
            var result = new ObjectResult(_courseService.GetCourses())
            {
                StatusCode = (int)HttpStatusCode.OK
            };
            Request.HttpContext.Response.Headers.Add("X-Count", _courseService.GetCourses().Count.ToString());

            return result;
        }

        //Api/Course/id

        [HttpGet("{id}")]

        public IActionResult GetCourse(int id)
        {
            if (_courseService.IsExist(id))
            {
                return Ok(_courseService.GetCourseById(id));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult PostCourse([FromBody] Course course)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            course.CreateDate = DateTime.Now;
            _courseService.AddCourse(course);
            return CreatedAtAction("GetCourse", new { id = course.CourseId }, course);
        }
    }
}