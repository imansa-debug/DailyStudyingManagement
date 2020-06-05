using DSM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Application.Interfaces
{
    public interface ICourseService
    {

        List<Course> GetCourses();
        Course GetCourseById(int id);
        void AddCourse(Course course);
        bool IsExist(int id);
    }
}
