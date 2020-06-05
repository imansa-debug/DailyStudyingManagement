using DSM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSM.Application.Interfaces
{
    public interface ICourseDetailService
    {
        List<CourseDetails> GetCourseDetailsByCourseId(int id);
        CourseDetails GetCourseDetailsByCourseIdAndCourseDetailId(int courseId, int courseDetailId);
    }
}
