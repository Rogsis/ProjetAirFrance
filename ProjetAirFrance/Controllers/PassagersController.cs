using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetAirFrance.Controllers
{
    public class PassagersController : Controller
    {
        // GET: Passagers
        public ActionResult Passagers()
        {
            return View();
        }
    }
}