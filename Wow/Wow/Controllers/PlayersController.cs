using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Wow.Models;
using Wow.ViewModels;

namespace Wow.Controllers
{

    public class PlayersController : Controller
    {
        private ApplicationDbContext _context;

        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new PlayerFormViewModel()
            {
                Player = new Player(),
                MembershipTypes = membershipTypes
            };

            return View("PlayerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Player player)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PlayerFormViewModel
                {
                    Player = player,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("PlayerForm", viewModel);
            }

            if (player.Id == 0)
                _context.Players.Add(player);
            else
            {
                var playerInDb = _context.Players.Single(c => c.Id == player.Id);
                playerInDb.Name = player.Name;
                playerInDb.Birthdate = player.Birthdate;
                playerInDb.MembershipTypeId = player.MembershipTypeId;
                playerInDb.IsSubscribed = player.IsSubscribed;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Players");
        }

        public ViewResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var player = _context.Players.Include(c => c.MembershipType).SingleOrDefault(p => p.Id == id);

            if (player == null)
                return HttpNotFound();

            return View(player);
        }

        public ActionResult Edit(int id)
        {
            var player = _context.Players.SingleOrDefault(p => p.Id == id);

            if (player == null)
                return HttpNotFound();

            var viewModel = new PlayerFormViewModel
            {
                Player = player,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("PlayerForm", viewModel);
        }
    }
}