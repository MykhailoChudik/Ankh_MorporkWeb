using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models.AM;

namespace WebApplication2.Data
{
    public class AddInform
    {
        public static List<Beggary> GetBeggary()
        {
            var beggaries = new List<Beggary>()
            {
                new Beggary() {IdBeggary = 1, Name = "Twitchers", Price = 300},
                new Beggary() {IdBeggary = 2, Name = "Droolers", Price = 200},
                new Beggary() {IdBeggary = 3, Name = "Dribblers", Price = 100},
                new Beggary() {IdBeggary = 4, Name = "Mumblers", Price = 100},
                new Beggary() {IdBeggary = 5, Name = "Mutterers", Price = 90},
                new Beggary() {IdBeggary = 6, Name = "Walking - Along - Shouters", Price = 80},
                new Beggary() {IdBeggary = 7, Name = "Demanders of a Chip", Price = 60},
                new Beggary() {IdBeggary = 8, Name = "People Who Call Other People Jimmy", Price = 50},
                new Beggary() {IdBeggary = 9, Name = "People Who Need Eightpence For A Meal", Price = 8},
                new Beggary() {IdBeggary = 10, Name = "People Who Need Tuppence For A Cup Of Tea", Price = 2},
                new Beggary() {IdBeggary = 11, Name = "People With Placards Saying \"Why lie ? I need a beer\"", Price = 0}
            };
            return beggaries;
        }

        public static List<Fools> GetFools()
        {
            var fools = new List<Fools>()
            {
                new Fools() {IdFools = 1, Name = "Muggins", Price = 50},
                new Fools() {IdFools = 2, Name = "Gull", Price = 100},
                new Fools() {IdFools = 3, Name = "Dupe", Price = 200},
                new Fools() {IdFools = 4, Name = "Butt", Price = 300},
                new Fools() {IdFools = 5, Name = "Fool", Price = 500},
                new Fools() {IdFools = 6, Name = "Tomfool", Price = 600},
                new Fools() {IdFools = 7, Name = "Stupid Fool", Price = 700},
                new Fools() {IdFools = 8, Name = "Arch Fool", Price = 800},
                new Fools() {IdFools = 9, Name = "Complete Fool", Price = 1000},
            };
            return fools;
        }


        public static List<Assasins> GetAssassins()
        {
            var assasins = new List<Assasins>()
            {
                new Assasins() {IdAssassins = 1, Name = "Assassin 1", MinPrice = 1500, MaxPrice = 2000, Work = true},
                new Assasins() {IdAssassins = 2, Name = "Assassin 2", MinPrice = 1000, MaxPrice = 2000, Work = false},
                new Assasins() {IdAssassins = 3, Name = "Assassin 3", MinPrice = 700, MaxPrice = 1200, Work = true},
                new Assasins() {IdAssassins = 4, Name = "Assassin 4", MinPrice = 1500, MaxPrice = 1900, Work = false},
                new Assasins() {IdAssassins = 5, Name = "Assassin 5", MinPrice = 1300, MaxPrice = 1500, Work = true},
                new Assasins() {IdAssassins = 6, Name = "Assassin 6", MinPrice = 600, MaxPrice = 1300, Work = true},
                new Assasins() {IdAssassins = 7, Name = "Assassin 7", MinPrice = 1700, MaxPrice = 2200, Work = false},
                new Assasins() {IdAssassins = 8, Name = "Assassin 8", MinPrice = 2400, MaxPrice = 2700, Work = false}
            };

            return assasins;
        }

        public static List<Player> GetPlayer()
        {
            var player = new List<Player>()
            {
                new Player() {Id = 1, Gold = 10000, Thieves = 0, Beer = 0}
            };

            return player;
        }
    }
}