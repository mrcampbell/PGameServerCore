using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGameServerCore.RestAPI.Models
{
    public class TrainerDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public int DaysSinceStart { get; set; }
        
    }
}
