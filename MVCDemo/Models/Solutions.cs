using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Models
{
    [Table("tblChallengesSolutions")]
   
   
    public class Solutions
    {
        public int ChallengeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Solution { get; set; }
        public SelectList SolutionList { get; set; }

        public bool success { get; set;}

    }
}