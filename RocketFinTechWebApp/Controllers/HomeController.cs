using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RocketFinTechWebApp.Models;

namespace RocketFinTechWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Qualify()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Sorry()
        {
            ViewBag.Message = "You can try Sears";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ProcessForm(UserData UserInfo)
        {
            ViewBag.ClientName = UserInfo.Username;
            ViewBag.Income = UserInfo.Income;
            ViewBag.Score = UserInfo.Score;


            if (UserInfo.Score == "550-649")

                return View("Sorry");

            else
                return View ("Checkout");
        }
    }
}