using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Data;
using WebApplication2.Models.AM;
using WebApplication2.Models.MessageModels;

namespace WebApplication2.Controllers
{
    public class AssasinsController : Controller
    {
        private AMContext db = new AMContext();
        private string AssassinsName;

        // GET: Assasins
        public ActionResult Index(AssassinsMessageModel model)
        {
            return View(model);
        }

        public ActionResult CreateContract(AssassinsMessageModel model)
        {
            return View("Contract", model);
        }

        public ActionResult Contract(AssassinsMessageModel model, string contractValue)
        {
            var price = Convert.ToInt32(contractValue) * 100;

            if (CheckWork(price) && price > 0)
            {
                db.Player.Find(1).Gold -= price;
                db.SaveChanges();
               
                model.Name = AssassinsName;
                model.PlayerDollar = db.Player.Find(1).Gold / 100;
                model.PlayerPenny = db.Player.Find(1).Gold % 100;
                
                Shuffle();

                return View("Created", model);
            }

            return RedirectToAction("GameOver", "Player");
        }


        private bool CheckWork(int price)
        {
            foreach (var assassin in db.Assasin)
            {
                if (assassin.Work && (assassin.MinPrice <= price && price <= assassin.MaxPrice))
                {
                    AssassinsName = assassin.Name;

                    return true;
                }
            }

            return false;
        }

        private void Shuffle()
        {
            var rnd = new Random();
            foreach (var test in db.Assasin)
            {
                test.Work = Convert.ToBoolean(rnd.Next(2));
            }

            db.SaveChanges();
        }
    }
}
