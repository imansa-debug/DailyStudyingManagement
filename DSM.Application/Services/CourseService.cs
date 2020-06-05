using DSM.Application.Interfaces;
using DSM.Domain.Interfaces;
using DSM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Application.Services
{
    public class CourseService : ICourseService
    {

        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository=courseRepository;
        }

        public void AddCourse(Course course)
        {
            _courseRepository.Add(course);
        }

        public Course GetCourseById(int id)
        {
            return _courseRepository.GetCourseById(id);
        }

        public List<Course> GetCourses()
        {
            return _courseRepository.GetAllCourse();
        }

        public bool IsExist(int id)
        {
            var course = _courseRepository.GetCourseById(id);
            if (course != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
