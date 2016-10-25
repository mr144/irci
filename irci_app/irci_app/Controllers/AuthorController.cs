using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace irci_app.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult AuthorProfile()
        {
            return View();
        }

        public ActionResult SearchResult()
        {
            return View();
        }
    }
}