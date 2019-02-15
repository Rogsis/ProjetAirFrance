using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetAirFrance.Controllers
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

        public ActionResult Trajets()
        {
            ViewBag.Message = "Liste des trajets";

            return View();
        }

        public ActionResult Vol()
        {
            ViewBag.Message = "Détails du vol";

            return View();
        }

        public ActionResult Passagers()
        {
            ViewBag.Message = "Liste des passagers";

            return View();
        }

        public ActionResult Inscription()
        {
            ViewBag.Message = "Inscription au vol";

            return View();
        }
    }
}