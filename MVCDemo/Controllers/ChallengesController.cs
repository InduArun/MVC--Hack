using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using System.Data;

namespace MVCDemo.Controllers
{
    public class ChallengesController : Controller
    {
        // GET: Challenges
        public static int chalId { get; set; }
        ChallengeContext context = new ChallengeContext();
        public ActionResult ChallengesDetails(int id)
        {

            chalId = id;
            Challenges ch = new Challenges();
           ch.ChallengeDescription = context.GetDescriptionFromOption(id);
           
            return View(ch);
        }
        
        //[HttpGet]
        //public ActionResult ChallengesDetails()
        //{
        //    Session["ChallengeId"] = ch.Challengelist.SelectedValue;
        //    return View();
        //}
        [HttpPost]
        public ActionResult ChallengesDetails(Challenges ch)
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult PostSolution (int id)
        {
            return View();
        }*/

        public ActionResult ViewSolutions()
        {
            Solutions sol = new Solutions();
            //sol.SolutionList = new SelectList(challengecontext.GetSolutions(), "ChallengeId", "ChallengeDescription");
            var solGrid = context.GetSolutions();
            return View(solGrid);

        }

        public ActionResult DisplaySolution()
        {

            return View();
        }

    }
}