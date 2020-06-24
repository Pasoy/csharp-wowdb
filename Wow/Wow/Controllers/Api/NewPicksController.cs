using System;
using System.Linq;
using System.Web.Http;
using Wow.Dtos;
using Wow.Models;

namespace Wow.Controllers.Api
{
    public class NewPicksController : ApiController
    {
        private ApplicationDbContext _context;

        public NewPicksController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewPicks(NewPickDto newPick)
        {
            var player = _context.Players.Single(
                p => p.Id == newPick.PlayerId);

            var characters = _context.Characters.Where(
                c => newPick.CharacterIds.Contains(c.Id)).ToList();

            foreach (var character in characters)
            {
                if (character.isAvailable == 0)
                    return BadRequest("Character is not available.");

                character.isAvailable = 0;

                var rental = new Pick
                {
                    Player = player,
                    Character = character,
                    DatePicked = DateTime.Now
                };

                _context.Picks.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}