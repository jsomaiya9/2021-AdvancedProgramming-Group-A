using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheFootballFanClub.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //GET: About page
        public ActionResult About()
        {
            return View();
        }


        //GET: Contact page
        public ActionResult Contact()
        {
            return View();
        }


        //GET: League tables page
        public ActionResult LeagueTables()
        {
            return View();
        }
    }
}