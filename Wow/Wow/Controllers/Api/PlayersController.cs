using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wow.Dtos;
using Wow.Models;

namespace Wow.Controllers.Api
{
    public class PlayersController : ApiController
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

        // GET /api/players
        [HttpGet]
        public IHttpActionResult GetPlayers()
        {
            var playerDtos = _context.Players
                .Include(p => p.MembershipType)
                .ToList()
                .Select(Mapper.Map<Player, PlayerDto>);

            return Ok(playerDtos);
        }

        // GET /api/players/1
        [HttpGet]
        public IHttpActionResult GetPlayer(int id)
        {
            var player = _context.Players.SingleOrDefault(c => c.Id == id);

            if (player == null)
                return NotFound();

            return Ok(Mapper.Map<Player, PlayerDto>(player));
        }

        // POST /api/players
        [HttpPost]
        public IHttpActionResult CreatePlayer(PlayerDto playerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var player = Mapper.Map<PlayerDto, Player>(playerDto);
            _context.Players.Add(player);
            _context.SaveChanges();

            playerDto.Id = player.Id;
            return Created(new Uri(Request.RequestUri + "/" + player.Id), playerDto);
        }

        // PUT /api/players/1
        [HttpPut]
        public IHttpActionResult UpdatePlayer(int id, PlayerDto playerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var playerInDb = _context.Players.SingleOrDefault(c => c.Id == id);

            if (playerInDb == null)
                return NotFound();

            Mapper.Map(playerDto, playerInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/players/1
        [HttpDelete]
        public IHttpActionResult DeletePlayer(int id)
        {
            var playerInDb = _context.Players.SingleOrDefault(c => c.Id == id);

            if (playerInDb == null)
                return NotFound();

            _context.Players.Remove(playerInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
