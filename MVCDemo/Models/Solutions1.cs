using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Models
{
    [Table("tblChallengesSolutions")]
    public class Solutions1
    {
        [Required(ErrorMessage = "Please Enter Solution")]
        [Display(Name = "Post Solution")]
        public string solution { get; set; }

        [Required(ErrorMessage = "Please Enter User")]
        [Display(Name = "Name")]
        public string user{ get; set; }

        [Required(ErrorMessage = "Please Enter Department")]
        [Display(Name = "Team")]
        public string department { get; set; }
    }
}