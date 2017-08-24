using PGameServerCore.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGameServerCore.API.Services
{
    public interface IGameRepository
    {
        IEnumerable<Trainer> GetTrainers();
        Trainer GetTrainer(Guid trainerId);
        void AddTrainer(Trainer trainer);
    }
}
