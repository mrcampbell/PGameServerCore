using PGameServerCore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PGameServerCore.Shared.Entities;

namespace PGameServerCore.API.Services
{
    public class GameRepository : IGameRepository
    {
        private GameContext _context;

        public GameRepository(GameContext context)
        {
            _context = context;
        }

        public Trainer GetTrainer(Guid trainerId)
        {
            return _context.Trainers.FirstOrDefault(t => t.Id == trainerId);
        }

        public IEnumerable<Trainer> GetTrainers()
        {
            return _context.Trainers;
        }

        public void AddTrainer(Trainer trainer)
        {
            _context.Trainers.Add(trainer);
        }
    }
}
