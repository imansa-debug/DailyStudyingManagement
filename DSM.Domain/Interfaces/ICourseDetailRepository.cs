using DSM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSM.Domain.Interfaces
{
    public interface ICourseDetailRepository
    {

        List<CourseDetails> GetCourseDetailsByCourseId(int id);
        CourseDetails GetCourseDetailsByCourseIdAndCourseDetailId(int courseId, int courseDetailId);
    }
}
