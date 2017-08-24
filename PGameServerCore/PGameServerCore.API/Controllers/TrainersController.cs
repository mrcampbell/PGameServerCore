using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PGameServerCore.API.Models;
using PGameServerCore.Shared.Entities;
using PGameServerCore.API.Services;

namespace PGameServerCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Trainers")]
    public class TrainersController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public TrainersController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;

            if (!_gameRepository.GetTrainers().Any())
            {
                _gameRepository.AddTrainer(new Trainer() { Id = Guid.NewGuid(), Username = "Xeioneir" });
            }
        }

        // GET: api/Trainers
        [HttpGet()]
        public IActionResult GetTrainers()
        {
            //return _context.Trainer;
            //return new List<Trainer>() { new Trainer() { Id = Guid.NewGuid(), Username = "Mikeymikemike75" } };
            var trainersFromRepo = _gameRepository.GetTrainers();

            return Ok(trainersFromRepo);
        }

        //// GET: api/Trainers/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetTrainer([FromRoute] Guid id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var trainer = await _context.Trainers.SingleOrDefaultAsync(m => m.Id == id);

        //    if (trainer == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(trainer);
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

        //    _context.Trainers.Add(trainer);
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

        //    var trainer = await _context.Trainers.SingleOrDefaultAsync(m => m.Id == id);
        //    if (trainer == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Trainers.Remove(trainer);
        //    await _context.SaveChangesAsync();

        //    return Ok(trainer);
        //}

        //private bool TrainerExists(Guid id)
        //{
        //    return _context.Trainers.Any(e => e.Id == id);
        //}
    }
}