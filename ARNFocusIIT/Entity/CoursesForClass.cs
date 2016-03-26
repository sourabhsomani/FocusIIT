using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ARNFocusIIT.Entity
{
    public class CoursesForClass
    {
        [Key]
        public string ID { get; set; }
        public string ClassID { get; set; }

        public string CourseID { get; set; }
        [ForeignKey("ClassID")]
        public virtual Classes Classes { get; set; }

        [ForeignKey("CourseID")]
        public virtual Course Courses { get; set; }
    }
}