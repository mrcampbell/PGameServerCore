using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGameServerCore.RestAPI.Models
{
    public class TrainerForCreationDto
    {
        public Guid? Id { get; set; }
        public string UserName { get; set; }
        public ICollection<PokemonForCreationDto> Pokemon { get; set; }
        = new List<PokemonForCreationDto>();
    }
}
