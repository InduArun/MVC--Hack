using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class ChallengesController : Controller
    {
        // GET: Challenges
        public ActionResult ChallengesDetails()
        {
            return View();
        }

        public ActionResult ChallengeSubmit()
        {
            return View();
        }

        public ActionResult ViewSolutions()
        {
            return View();
        }
    }
}