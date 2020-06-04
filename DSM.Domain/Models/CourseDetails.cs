using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DSM.Domain.Models
{
    public class CourseDetails
    {
        public CourseDetails()
        {

        }
        [Key]
        public int CourseDetailsId { get; set; }
        public int CourseId { get; set; }
        [Required]
        public int DurationOfSession { get; set; }
        [Required]
        public DateTime VisitTime { get; set; }
        [Required]
        public string IsVisit { get; set; }


        //Navigation Properties

        public virtual Course Course { get; set; }

    }
}
