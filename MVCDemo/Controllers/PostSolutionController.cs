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
        // GET: PostSolution
        public ActionResult PostSolution()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostSolution(Solutions1 sol)
        {
            if (ModelState.IsValid) //checking model is valid or not
            {
                SolutionsContext solCo = new SolutionsContext();
                int result = solCo.InsertSolution(sol); // passing Value to DBClass from model
                ViewData["result"] = result;
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