using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Data;
using WebApplication2.Models.MessageModels;

namespace WebApplication2.Controllers
{
    public class FoolsController : Controller
    {
        private AMContext db = new AMContext();
        // GET: Boggard
        public ActionResult Index(FoolsMessageModel model)
        {
            return View(model);
        }

        public ActionResult Play(FoolsMessageModel model)
        {
            db.Player.Find(1).Gold += db.Fool.Find(model.Number).Price;
            db.SaveChanges();

            return RedirectToAction("Play", "Player");
        }
    }
}