using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ARNFocusIIT.Entity
{
    public class Course
    {
        [Key]
        public string ID { get; set; }
        [Required(ErrorMessage="Course Name cannot be Empty")]
        public string CourseName { get; set; }
        public DateTime Added { get; set; }
    }
}