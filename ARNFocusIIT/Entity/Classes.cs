using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ARNFocusIIT.Entity
{
    public class Classes
    {
        [Key]
        public string ID { get; set; }
        [Required(ErrorMessage="Class Name Can't Be Empty")]
        public string ClassName { get; set; }
        public string Added { get; set; }
    }
}