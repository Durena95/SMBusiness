using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// custom models
using SMBusiness.Models;

namespace SMBusiness.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Get: /home/requestaquote
        public ActionResult RequestAQuote()
        {
            return View();
        }
        //Post: /home/requestaquote 
        [HttpPost]
        public ActionResult RequestAQuote(RequestAQuoteModel quote)
        {
            try
            {
                return RedirectToAction("ThankYou");
            }
            catch
            {

                return View();
            }
        }
        //Get: /home/ThankYou
        public ActionResult ThankYou()
        {
            return View();
        }
    }
}