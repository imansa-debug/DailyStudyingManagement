using DSM.Domain.Interfaces;
using DSM.Domain.Models;
using DSM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSM.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DSMdBContext _context;
        public CourseRepository(DSMdBContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Add(course);
            _context.SaveChanges();
        }

        public List<Course> GetAllCourse()
        {
            return _context.Course.ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Course.SingleOrDefault(c=>c.CourseId==id);
        }
    }
}
