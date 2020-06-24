using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using Wow.Models;
using Wow.ViewModels;

namespace Wow.Controllers
{
    public class CharactersController : Controller
    {
        private ApplicationDbContext _context;

        public CharactersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var characters = _context.Characters.Include(m => m.Class).ToList();

            return View(characters);
        }
        public ViewResult New()
        {
            var classes = _context.Classes.ToList();
            var races = _context.Races.ToList();

            var viewModel = new CharacterFormViewModel
            {
                Classes = classes,
                Races = races
            };

            return View("CharacterForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var character = _context.Characters.SingleOrDefault(c => c.Id == id);

            if (character == null)
                return HttpNotFound();

            var viewModel = new CharacterFormViewModel(character)
            {
                Classes = _context.Classes.ToList(),
                Races = _context.Races.ToList()
            };

            return View("CharacterForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var character = _context.Characters.Include(c => c.Class).Include(c => c.Race).SingleOrDefault(c => c.Id == id);

            if (character == null)
                return HttpNotFound();

            return View(character);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Character character)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CharacterFormViewModel(character)
                {
                    Classes = _context.Classes.ToList(),
                    Races = _context.Races.ToList()
                };

                return View("CharacterForm", viewModel);
            }

            if (character.Id == 0)
            {
                character.DateCreated = DateTime.Now;
                _context.Characters.Add(character);
            }
            else
            {
                var characterInDb = _context.Characters.Single(m => m.Id == character.Id);
                characterInDb.Name = character.Name;
                characterInDb.ClassId = character.ClassId;
                characterInDb.ReleaseDate = character.ReleaseDate;
                characterInDb.RaceId = character.RaceId;
                characterInDb.Gender = character.Gender;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Characters");
        }

        public ActionResult Random()
        {
            var characters = new Character() { Name = "Shrek!" };
            var players = new List<Player>
            {
                new Player { Name = "Player 1" },
                new Player { Name = "Player 2" }
            };

            var viewModel = new RandomCharacterViewModel()
            {
                Character = characters,
                Players = players
            };

            return View(viewModel);
        }
    }
}