using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PGameServerCore.RestAPI.Models;
using PGameServerCore.Shared.Entities;
using PGameServerCore.RestAPI.Services;
using AutoMapper;

namespace PGameServerCore.RestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/trainers/{trainerId}/pokemon")]
    public class PokemonController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public PokemonController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        // GET: api/Pokemon
        [HttpGet]
        public IActionResult GetPokemonForTrainer(Guid trainerId)
        {
            if (!_gameRepository.TrainerExists(trainerId))
            {
                return NotFound();
            }

            var pokemonForTrainerFromRepo = _gameRepository.GetPokemonForTrainer(trainerId);

            var pokemonForTrainer = Mapper.Map<IEnumerable<PokemonDto>>(pokemonForTrainerFromRepo);

            return Ok(pokemonForTrainer);
        }

        //// GET: api/Pokemon/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetPokemon([FromRoute] Guid id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var pokemon = await _context.Pokemon.SingleOrDefaultAsync(m => m.Id == id);

        //    if (pokemon == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(pokemon);
        //}

        //// PUT: api/Pokemon/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPokemon([FromRoute] Guid id, [FromBody] Pokemon pokemon)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != pokemon.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(pokemon).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PokemonExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Pokemon
        //[HttpPost]
        //public async Task<IActionResult> PostPokemon([FromBody] Pokemon pokemon)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Pokemon.Add(pokemon);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPokemon", new { id = pokemon.Id }, pokemon);
        //}

        //// DELETE: api/Pokemon/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePokemon([FromRoute] Guid id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var pokemon = await _context.Pokemon.SingleOrDefaultAsync(m => m.Id == id);
        //    if (pokemon == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Pokemon.Remove(pokemon);
        //    await _context.SaveChangesAsync();

        //    return Ok(pokemon);
        //}

        //private bool PokemonExists(Guid id)
        //{
        //    return _context.Pokemon.Any(e => e.Id == id);
        //}
    }
}