using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ARNFocusIIT.Models
{
    public class Mail
    {
        [Required(ErrorMessage="Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please Enter Your Message")]
        public string Message { get; set; }
    }
}