using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Models.MessageModels;

namespace WebApplication2.Controllers
{
    public class PlayerController : Controller
    {
        private AMContext db = new AMContext();
        private Random rnd = new Random();
        // GET: Player
        public ActionResult Index()
        {
            return RedirectToAction("Play");
        }

        public ActionResult Play()
        {
            var gold = db.Player.Find(1).Gold;
            if (gold < 0)
                return View("Lose");

            switch (rnd.Next(5))
            {
                case 0:
                    return MeetBeggary();
                case 1:
                    return MeetFools();
                case 2:
                    return MeetThieves();
                case 3:
                    return MeetAssassins();
                case 4:
                    return MeetBeer();
            }

            return RedirectToAction("Play");
        }

        public ActionResult GameOver()
        {
            return View("Lose");
        }

        private ActionResult MeetBeggary()
        {
            var beggary = rnd.Next(1, 12);
            return RedirectToAction("Index", "Beggary", new BeggaryMessageModel
            {
                Name = db.Beggaries.Find(beggary).Name,
                Number = beggary,
                CostDollar = db.Beggaries.Find(beggary).Price / 100,
                CostPenny = db.Beggaries.Find(beggary).Price % 100,
                PlayerDollar = db.Player.Find(1).Gold / 100,
                PlayerPenny = db.Player.Find(1).Gold % 100,
                Type = "Beggary",
                Beer = db.Player.Find(1).Beer
            });
        }

        private ActionResult MeetFools()
        {
            var fools = rnd.Next(1, 10);
            return RedirectToAction("Index", "Fools", new FoolsMessageModel
            {
                Name = db.Fool.Find(fools).Name,
                Number = fools,
                CostDollar = db.Fool.Find(fools).Price / 100,
                CostPenny = db.Fool.Find(fools).Price % 100,
                PlayerDollar = db.Player.Find(1).Gold / 100,
                PlayerPenny = db.Player.Find(1).Gold % 100,
            });
        }

        private ActionResult MeetThieves()
        {
            return RedirectToAction("Index", "Thieves", new ThievesMessageModel
            {
                PlayerDollar = db.Player.Find(1).Gold / 100,
                PlayerPenny = db.Player.Find(1).Gold % 100,
                Type = "Thieves"
            });
        }

        private ActionResult MeetAssassins()
        {
            return RedirectToAction("Index", "Assasins", new AssassinsMessageModel
            {
                Name = null,
                PlayerDollar = db.Player.Find(1).Gold / 100,
                PlayerPenny = db.Player.Find(1).Gold % 100,
                Type = "Assassins"
            });
        }

        private ActionResult MeetBeer()
        {
            return RedirectToAction("Index", "Beer", new BeerMessageModel
            {
                PlayerDollar = db.Player.Find(1).Gold / 100,
                PlayerPenny = db.Player.Find(1).Gold % 100,
                Number = db.Player.Find(1).Beer,
                CostDollar = 5
            });
        }
    }
}