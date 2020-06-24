using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Wow.Dtos;
using Wow.Models;

namespace Wow.Controllers.Api
{
    public class CharactersController : ApiController
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

        [HttpGet]
        public IEnumerable<CharacterDto> GetCharacters()
        {
            return _context.Characters
                .Include(c => c.Class)
                .Include(c => c.Race)
                .ToList()
                .Select(Mapper.Map<Character, CharacterDto>);
        }

        [HttpGet]
        public IHttpActionResult GetCharacter(int id)
        {
            var character = _context.Characters.SingleOrDefault(c => c.Id == id);

            if (character == null)
                return NotFound();

            return Ok(Mapper.Map<Character, CharacterDto>(character));
        }

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult CreateCharacter(CharacterDto characterDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var character = Mapper.Map<CharacterDto, Character>(characterDto);
            _context.Characters.Add(character); 
            _context.SaveChanges();

            characterDto.Id = character.Id;
            return Created(new Uri(Request.RequestUri + "/" + character.Id), characterDto);
        }

        [HttpPut]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult UpdateCharacter(int id, CharacterDto characterDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var characterInDb = _context.Characters.SingleOrDefault(c => c.Id == id);

            if (characterInDb == null)
                return NotFound();

            Mapper.Map(characterDto, characterInDb);

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult DeleteCharacter(int id)
        {
            var characterInDb = _context.Characters.SingleOrDefault(c => c.Id == id);

            if (characterInDb == null)
                return NotFound();

            _context.Characters.Remove(characterInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
