using DSM.Application.Interfaces;
using DSM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSM.Application.Services
{
    public class CourseDetailService : ICourseDetailService
    {

        private readonly ICourseDetailService _courseDetailService;
        public CourseDetailService(ICourseDetailService courseDetailService)
        {
            _courseDetailService = courseDetailService;

        }
        public List<CourseDetails> GetCourseDetailsByCourseId(int id)
        {
            return _courseDetailService.GetCourseDetailsByCourseId(id);
        }

        public CourseDetails GetCourseDetailsByCourseIdAndCourseDetailId(int courseId, int courseDetailId)
        {
            return _courseDetailService.GetCourseDetailsByCourseIdAndCourseDetailId(courseId, courseDetailId);
        }
    }
}
