using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetAirFrance.Controllers
{
    public class TrajetsController : Controller
    {
        // GET: Trajets
        public ActionResult Index()
        {
            return View();
        }
    }
}