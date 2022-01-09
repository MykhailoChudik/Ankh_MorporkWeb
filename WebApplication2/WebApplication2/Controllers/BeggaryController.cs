using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Data;
using WebApplication2.Models.MessageModels;

namespace WebApplication2.Controllers
{
    public class BeggaryController : Controller
    {
        private AMContext db = new AMContext();
        // GET: Boggard
        public ActionResult Index(BeggaryMessageModel model)
        {
            if (model.Number == 11)
                return View("BeggaryBeer", model);

            return View(model);
        }

        public ActionResult Play(BeggaryMessageModel model)
        {
            db.Player.Find(1).Gold -= db.Beggaries.Find(model.Number).Price;
            db.SaveChanges();

            return RedirectToAction("Play", "Player");
        }

        public ActionResult GiveBeer()
        {
            db.Player.Find(1).Beer -= 1;
            db.SaveChanges();

            if (db.Player.Find(1).Beer < 0)
                return View("NotBeer");

            return RedirectToAction("Play", "Player");
        }

        public ActionResult Beer()
        {
            return View("NotBeer");
        }
    }
}