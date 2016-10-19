using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace irci_app.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Article()
        {
            return View();
        }
    }
}