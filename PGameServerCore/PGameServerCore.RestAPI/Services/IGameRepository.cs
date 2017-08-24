using PGameServerCore.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGameServerCore.RestAPI.Services
{

    public interface IGameRepository
    {
        // Trainer Exclusive Functions
        IEnumerable<Trainer> GetTrainers();
        Trainer GetTrainer(Guid trainerId);
        IEnumerable<Trainer> GetTrainers(IEnumerable<Guid> trainerIds);
        void AddTrainer(Trainer trainer);
        void DeleteTrainer(Trainer trainer);
        void UpdateTrainer(Trainer trainer);
        bool TrainerExists(Trainer trainer);
        bool TrainerExists(Guid trainerId);

        // Pokemon Exclusive Functions
        IEnumerable<Pokemon> GetPokemonForTrainer(Guid trainerId);
        Pokemon GetPokemonForTrainer(Guid trainerId, Guid pokemonId);
        void AddPokemonForTrainer(Guid trainerId, Pokemon pokemon);
        void UpdatePokemonForTrainer(Pokemon pokemon);
        void DeletePokemon(Pokemon pokemon);
        bool Save();
    }
}
