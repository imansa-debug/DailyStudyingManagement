using DSM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSM.Domain.Interfaces
{
    public interface ICourseRepository
    {

        List<Course> GetAllCourse();
        Course GetCourseById(int id);
        void Add(Course course);
    }
}
