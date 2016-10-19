using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace irci_app.Controllers
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
        public ActionResult SearchResult(string srcTxt, string srcCat)
        {
            //var movies = from m in db.Movies
                         //select m;

            //if (!String.IsNullOrEmpty(srcTxt))
            //{

                //movies = movies.Where(s => s.Title.Contains(searchString));
            //}

            //return View(movies);
            //ViewBag.Message = srcTxt + " " + srcCat;
            return View();
            //sjdkfjsd
        }
    }
}