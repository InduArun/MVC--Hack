using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Models
{
    [Table("tblChallengesMaster")]
    public class Challenges
    {
        public int ChallengeId { get; set; }

        public string ChallengeTitle { get; set;}

        public string ChallengeDescription { get; set; }

        public SelectList Challengelist { get; set; }

        public int SelectedValueInDropDown { get; set;}

    }
}