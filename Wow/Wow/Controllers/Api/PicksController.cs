using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Wow.Dtos;
using Wow.Models;

namespace Wow.Controllers.Api
{
    public class PicksController : ApiController
    {
        private ApplicationDbContext _context;

        public PicksController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IEnumerable<PickDto> GetPicks()
        {
            return _context.Picks
                .Include(c => c.Character)
                .Include(c => c.Player)
                .ToList()
                .Select(Mapper.Map<Pick, PickDto>);
        }

        [HttpGet]
        public IHttpActionResult GetPick(int id)
        {
            var pick = _context.Picks.SingleOrDefault(c => c.Id == id);

            if (pick == null)
                return NotFound();

            return Ok(Mapper.Map<Pick, PickDto>(pick));
        }

        [HttpPost]
        public IHttpActionResult CreatePicks(PickDto newPick)
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

                var pick = new Pick
                {
                    Player = player,
                    Character = character,
                    DatePicked = DateTime.Now
                };

                _context.Picks.Add(pick);
            }

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeletePick(int id)
        {
            var pickInDb = _context.Picks.SingleOrDefault(c => c.Id == id);

            if (pickInDb == null)
                return NotFound();

            _context.Picks.Remove(pickInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}