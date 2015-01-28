using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bkwdesign.web.math.Models;
using bkwdesign.web.math.extensions;

namespace bkwdesign.web.math.Controllers
{
    public class FibonacciController : Controller
    {
        // Default route - first visit...
        // GET: /Fibonacci/
        // GET: /
        public ActionResult Index()
        {
            MathResponse mr = MathResponse.EmptyResponse();//new user to site.. give the view an empty model
            return View("Compute",mr);
        }

        /// <summary>
        /// GET: /Fibonacci/8
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public ActionResult Compute(long input)
        {
            try
            {
                    MathResponse mr = new Models.MathResponse();
                    mr.CaptureOrigin(this);
                    mr.UserQuery = input;
                    mr.Response = bkwdesign.math.fibonacci.GetNthNumber(input);
                    mr.LogRequest();//extn. method
                    return View(mr);
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", ex);
            }
            
        }

        [HttpPost]
        public ActionResult Compute(Models.MathResponse mr)
        {
            //although this works...
            //return Compute(mr.UserQuery);
            return RedirectToAction("Compute",new {input = mr.UserQuery});//in this case, I prefer nice route to show in address bar
        }
    }
}
