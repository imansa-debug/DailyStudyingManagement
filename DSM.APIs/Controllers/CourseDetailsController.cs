using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DSM.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DSM.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseDetailsController : ControllerBase
    {

        private ICourseDetailService _courseDetailService;

        public CourseDetailsController(ICourseDetailService courseDetailService)
        {
            _courseDetailService = courseDetailService;
        }
        // GET: api/CourseDetails/id
        [HttpGet("{id}")]
        public IActionResult GetCourseDetails(int id)
        {
            var result = new ObjectResult(_courseDetailService.GetCourseDetailsByCourseId(id))
            {
                StatusCode = (int)HttpStatusCode.OK
            };

        return result;
        }

        //// GET: api/CourseDetails/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/CourseDetails
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/CourseDetails/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
