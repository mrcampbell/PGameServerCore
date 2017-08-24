using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PGameServerCore.Shared.Entities;
using PGameServerCore.RestAPI.Models;

namespace PGameServerCore.RestAPI.Services
{
    public class GameRepository : IGameRepository
    {
        private GameContext _context;

        public GameRepository(GameContext context)
        {
            _context = context;
        }

        public void AddPokemonForTrainer(Guid trainerId, Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public void AddTrainer(Trainer trainer)
        {
            if (trainer.Id == null || trainer.Id == Guid.Empty)
            {
                trainer.Id = Guid.NewGuid();
            }

            _context.Trainer.Add(trainer);
        }

        public void DeletePokemon(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public void DeleteTrainer(Trainer trainer)
        {
            _context.Trainer.Remove(trainer);
        }

        public IEnumerable<Pokemon> GetPokemonForTrainer(Guid trainerId)
        {
            return _context.Pokemon.Where(p => p.TrainerId == trainerId);
        }

        public Pokemon GetPokemonForTrainer(Guid trainerId, Guid pokemonId)
        {
            return _context.Pokemon.Where(p => p.TrainerId == trainerId && p.Id == pokemonId).FirstOrDefault();
        }

        public Trainer GetTrainer(Guid trainerId)
        {
            return _context.Trainer.FirstOrDefault(t => t.Id == trainerId);
        }

        public IEnumerable<Trainer> GetTrainers()
        {
            // TODO: Add further sorting?
            return _context.Trainer.OrderBy(t => t.Username);
        }

        public IEnumerable<Trainer> GetTrainers(IEnumerable<Guid> trainerIds)
        {
            return _context.Trainer.Where(t => trainerIds.Contains(t.Id))
                .OrderBy(t => t.Username);
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool TrainerExists(Trainer trainer)
        {
            return _context.Trainer.Any(t => t.Id == trainer.Id);
        }

        public bool TrainerExists(Guid trainerId)
        {
            return _context.Trainer.Any(t => t.Id == trainerId);
        }

        public void UpdatePokemonForTrainer(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public void UpdateTrainer(Trainer trainer)
        {
            // not implemented yet..
        }
    }
}
