using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Data;
using WebApplication2.Models.MessageModels;

namespace WebApplication2.Controllers
{
    public class BeerController : Controller
    {
        private AMContext db = new AMContext();
        // GET: Beer
        public ActionResult Index(BeerMessageModel model)
        {
            if (model.Number == 1)
            {
                return View("IndexOne", model);

            }

            if (model.Number == 2)
            {
                return View("IndexTwo", model);
            }

            return View("IndexZero", model);
        }

        public ActionResult Buy1()
        {
            db.Player.Find(1).Gold -= 500;
            db.Player.Find(1).Beer += 1;
            db.SaveChanges();

            return RedirectToAction("Play", "Player");
        }

        public ActionResult Buy2()
        {
            db.Player.Find(1).Gold -= 900;
            db.Player.Find(1).Beer += 2;
            db.SaveChanges();

            return RedirectToAction("Play", "Player");
        }
    }
}