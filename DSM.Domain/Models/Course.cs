using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DSM.Domain.Models
{
   public class Course
    {

        public Course()
        {

        }
        [Key]
        public int CourseId { get; set; }
        [MaxLength(200)]
        [Required]
        public string Title { get; set; }
        [MaxLength(500)]
        [Required]
        public string Description { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public int NumberOfSessions { get; set; }
        [MaxLength(200)]
        [Required]
        public string TeacherName { get; set; }
        [MaxLength(200)]
        [Required]
        public string ImageName { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        //Navigation Properties
        public List<CourseDetails> CourseDetails { get; set; }
    }
}
