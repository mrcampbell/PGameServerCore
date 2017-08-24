using PGameServerCore.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGameServerCore.RestAPI.Models
{
    public class PokemonDto
    {
        public Guid Id { get; set; }
        public int BreedNum { get; set; }
        public string Name { get; set; }

        public Guid TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        public int TotalEV { get; set; }
        public int TotalIV { get; set; }
    }
}
