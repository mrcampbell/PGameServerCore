using PGameServerCore.RestAPI.Models;
using PGameServerCore.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGameServerCore.RestAPI.Data
{
    public static class GameContextExtensions
    {
        public static void EnsureSeedDataForContext(this GameContext context)
        {
            context.Trainer.RemoveRange(context.Trainer);
            context.SaveChanges();

            var trainers = new List<Trainer>()
            {
                new Trainer()
                {
                    Id = new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                    Username = "MikeyMikeMike75"
                },
                new Trainer()
                {
                    Id = new Guid("76053df4-6687-4353-8937-b45556748abe"),
                    Username = "Ash"
                },
                new Trainer()
                {
                    Id = new Guid("412c3012-d891-4f5e-9613-ff7aa63e6bb3"),
                    Username = "Xeioneir"
                }
            };

            context.Trainer.AddRange(trainers);
            context.SaveChanges();
        }
    }
}
