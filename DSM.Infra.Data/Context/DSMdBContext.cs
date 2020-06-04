using DSM.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;

namespace DSM.Infra.Data.Context
{
    public class DSMdBContext:DbContext
    {
        public DSMdBContext(DbContextOptions<DSMdBContext> options):base(options)
        {

        }

        public DbSet<Course> Course { get; set; }
        public DbSet<CourseDetails> CourseDetails { get; set; }
    }
}
