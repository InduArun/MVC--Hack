using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using System.Data;

namespace MVCDemo.Controllers
{
    public class PostSolutionController : Controller
    {
        // ViewBag.isFalse = false;
        // GET: PostSolution

       public int id;
        public ActionResult PostSolution()
        {
           id =  ChallengesController.chalId;
            return View();
        }

        [HttpPost]
        public ActionResult PostSolution(Solutions1 sol)
        {
            ViewBag.isSuccess = null;
            if (ModelState.IsValid) //checking model is valid or not

            {
                SolutionsContext solCo = new SolutionsContext();
                int result = solCo.InsertSolution(sol,
                    ChallengesController.chalId);

                // passing Value to DBClass from model
                ViewData["result"] = result;

                ViewBag.SuccessMessage = "Successfully Posted Your Solution";
              
                ViewBag.isSuccess = true;

                ModelState.Clear(); //clearing model
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Error in saving data");
                return View();
            }
        }
        
    }
}