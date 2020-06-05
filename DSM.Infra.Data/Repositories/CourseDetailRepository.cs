using DSM.Domain.Interfaces;
using DSM.Domain.Models;
using DSM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSM.Infra.Data.Repositories
{
    public class CourseDetailRepository : ICourseDetailRepository
    {
        private readonly DSMdBContext _context;
        public CourseDetailRepository(DSMdBContext context)
        {
            _context = context;

        }
        public List<CourseDetails> GetCourseDetailsByCourseId(int id)
        {
            return _context.CourseDetails.ToList();
        }

        public CourseDetails GetCourseDetailsByCourseIdAndCourseDetailId(int courseId, int courseDetailId)
        {
            return _context.CourseDetails.SingleOrDefault(c => c.CourseDetailsId == courseDetailId && c.CourseId == courseId);
        }
    }
}
