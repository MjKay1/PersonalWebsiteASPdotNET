using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsiteASPdotNET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I am currently working as an Engineering Geologist having completed an MSc in GIS at the University of Leeds, and a BSc (Hons) in Geology and Petroleum Geology at the University of Aberdeen. For more information on the courses, please click on the pictures below. In my free time i enjoy woodworking, mainly creating Dice Towers for Tabletop games (another hobby of mine) as well as following numerous sports teams.";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "All of the Projects that I have completed as part of the programming course during my MSc are listed below, Please click on the images for links to each projects repository on GitHub. Additionally, a selection of photographs from various woodworking projects can be found below(click the image for photo gallery).";

            return View();
        }
    }
}