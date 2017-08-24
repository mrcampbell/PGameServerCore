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
            context.Pokemon.RemoveRange(context.Pokemon);
            context.SaveChanges();

            var trainers = new List<Trainer>()
            {
                new Trainer()
                {
                    Id = new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                    Username = "MikeyMikeMike75",
                    Pokemon = new List<Pokemon>()
                    {
                        new Pokemon()
                        {
                            Id = new Guid("c7ba6add-09c4-45f8-8dd0-eaca221e5d93"),
                            BreedNum = 150,
                            Name = "Mewtwo",
                            EV_HP = 99,
                            EV_ATK = 1,
                            EV_DEF = 23,
                            EV_SPEC_ATK = 5,
                            EV_SPEC_DEF = 22,
                            EV_SPEED = 100,
                            IV_ATK = 15,
                            IV_DEF = 15,
                            IV_HP = 15,
                            IV_SPEC_ATK = 15,
                            IV_SPEC_DEF = 15,
                            IV_SPEED = 15,
                        },
                        new Pokemon()
                        {
                            Id = new Guid("a3749477-f823-4124-aa4a-fc9ad5e79cd6"),
                            BreedNum = 7,
                            Name = "Charizard",
                            EV_HP = 1000,
                            EV_ATK = 1213,
                            EV_DEF = 23134,
                            EV_SPEC_ATK = 5324,
                            EV_SPEC_DEF = 22234,
                            EV_SPEED = 10034,
                            IV_ATK = 9,
                            IV_DEF = 3,
                            IV_HP = 2,
                            IV_SPEC_ATK = 1,
                            IV_SPEC_DEF = 15,
                            IV_SPEED = 4,
                        }
                    }
                },
                new Trainer()
                {
                    Id = new Guid("76053df4-6687-4353-8937-b45556748abe"),
                    Username = "Ash",
                     Pokemon = new List<Pokemon>()
                    {
                        new Pokemon()
                        {
                            Id = new Guid("447eb762-95e9-4c31-95e1-b20053fbe215"),
                            BreedNum = 25,
                            Name = "Pikachu",
                            EV_HP = 99,
                            EV_ATK = 1,
                            EV_DEF = 23,
                            EV_SPEC_ATK = 5,
                            EV_SPEC_DEF = 22,
                            EV_SPEED = 100,
                            IV_ATK = 15,
                            IV_DEF = 15,
                            IV_HP = 15,
                            IV_SPEC_ATK = 15,
                            IV_SPEC_DEF = 15,
                            IV_SPEED = 15,
                        }
                     }
                },
                new Trainer()
                {
                    Id = new Guid("412c3012-d891-4f5e-9613-ff7aa63e6bb3"),
                    Username = "Xeioneir",
                      Pokemon = new List<Pokemon>()
                    {
                        new Pokemon()
                        {
                            Id = new Guid("9edf91ee-ab77-4521-a402-5f188bc0c577"),
                            BreedNum = 0,
                            Name = "MissingNo",
                            EV_HP = 99,
                            EV_ATK = 1,
                            EV_DEF = 23,
                            EV_SPEC_ATK = 5,
                            EV_SPEC_DEF = 22,
                            EV_SPEED = 100,
                            IV_ATK = 15,
                            IV_DEF = 15,
                            IV_HP = 15,
                            IV_SPEC_ATK = 15,
                            IV_SPEC_DEF = 15,
                            IV_SPEED = 15,
                        }
                     }
                }
            };

            context.Trainer.AddRange(trainers);
            context.SaveChanges();
        }
    }
}
