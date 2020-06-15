using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WoWDB_Web.Models;

namespace WoWDB_Web.Controllers
{
    public class CharactersController : Controller
    {
        // GET: Characters
        public ViewResult Index()
        {
            var characters = GetCharacters();

            return View(characters);
        }

        public ActionResult Details(int id)
        {
            var character = GetCharacters().SingleOrDefault(c => c.Id == id);

            if (character == null)
                return HttpNotFound();

            return View(character);
        }

        private IEnumerable<Character> GetCharacters()
        {
            return new List<Character>
            {
                new Character { Id = 1, Name = "Pasorium", Class = "Priest", Race = "Dwarf" },
                new Character { Id = 2, Name = "SumOthaDud", Class = "Warrior", Race = "Human" }
            };
        }
    }
}