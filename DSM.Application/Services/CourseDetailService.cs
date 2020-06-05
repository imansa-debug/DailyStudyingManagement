using DSM.Application.Interfaces;
using DSM.Domain.Interfaces;
using DSM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSM.Application.Services
{
    public class CourseDetailService : ICourseDetailService
    {

        private readonly ICourseDetailRepository _courseDetailRepository;
        public CourseDetailService(ICourseDetailRepository courseDetailRepository)
        {
            _courseDetailRepository = courseDetailRepository;

        }
        public List<CourseDetails> GetCourseDetailsByCourseId(int id)
        {
            return _courseDetailRepository.GetCourseDetailsByCourseId(id);
        }

        public CourseDetails GetCourseDetailsByCourseIdAndCourseDetailId(int courseId, int courseDetailId)
        {
            return _courseDetailRepository.GetCourseDetailsByCourseIdAndCourseDetailId(courseId, courseDetailId);
        }
    }
}
