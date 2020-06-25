using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wow.Models;

namespace Wow.Controllers
{
    public class PicksController : Controller
    {
        // GET: Picks
        public ActionResult New()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View("List");
        }
    }
}