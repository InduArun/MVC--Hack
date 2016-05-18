using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {

        ChallengeContext challengecontext = new ChallengeContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Challenges()
        {

            Challenges ch = new Challenges();
             ch.Challengelist = new SelectList(challengecontext.GetOptions(), "ChallengeId", "ChallengeDescription");
              return View(ch);
        }
    }
}