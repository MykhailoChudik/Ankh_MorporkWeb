using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private AMContext db = new AMContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Play()
        {
            db.Player.Find(1).Gold = 10000;
            db.Player.Find(1).Thieves = 0;
            db.Player.Find(1).Beer = 0;
            db.SaveChanges();

            return RedirectToAction("Index", "Player");
        }
    }
}