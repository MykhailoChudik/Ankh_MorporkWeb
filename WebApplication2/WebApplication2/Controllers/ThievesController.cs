using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Data;
using WebApplication2.Models.MessageModels;

namespace WebApplication2.Controllers
{
    public class ThievesController : Controller
    {
        private AMContext db = new AMContext();

        // GET: Thieves
        public ActionResult Index(ThievesMessageModel model)
        {
            db.Player.Find(1).Thieves += 1;
            db.SaveChanges();
            
            if(db.Player.Find(1).Thieves > 6)
                return View("MeetOll", model);

            return View(model);
        }

        public ActionResult Play()
        {
            db.Player.Find(1).Gold -= 1000;
            db.SaveChanges();

            return RedirectToAction("Play", "Player");
        }
    }
}