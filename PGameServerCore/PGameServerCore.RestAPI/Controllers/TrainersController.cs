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
    [Route("api/v1/trainers")]
    public class TrainersController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public TrainersController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        // GET: api/trainers
        [HttpGet()]
        public IActionResult GetTrainers()
        {
            var trainersFromRepo = _gameRepository.GetTrainers();

            // TODO: MAP
            var trainers = Mapper.Map<IEnumerable<TrainerDto>>(trainersFromRepo);

            return Ok(trainers);
        }

        // GET: api/Trainers/5
        [HttpGet("{id}", Name = "GetTrainer")]
        public async Task<IActionResult> GetTrainer([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var trainerFromRepo = _gameRepository.GetTrainer(id);

            if (trainerFromRepo == null)
            {
                return NotFound();
            }

            var trainer = Mapper.Map<TrainerDto>(trainerFromRepo);

            return Ok(trainer);
        }

        //[HttpPost]
        //public IActionResult CreateTrainer([FromBody] TrainerForCreationDto trainer)
        //{

        //}

        //// PUT: api/Trainers/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTrainer([FromRoute] Guid id, [FromBody] Trainer trainer)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != trainer.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(trainer).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TrainerExists(id))
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

        //// POST: api/Trainers
        //[HttpPost]
        //public async Task<IActionResult> PostTrainer([FromBody] Trainer trainer)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Trainer.Add(trainer);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTrainer", new { id = trainer.Id }, trainer);
        //}

        //// DELETE: api/Trainers/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTrainer([FromRoute] Guid id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var trainer = await _context.Trainer.SingleOrDefaultAsync(m => m.Id == id);
        //    if (trainer == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Trainer.Remove(trainer);
        //    await _context.SaveChangesAsync();

        //    return Ok(trainer);
        //}

        //private bool TrainerExists(Guid id)
        //{
        //    return _context.Trainer.Any(e => e.Id == id);
        //}
    }
}