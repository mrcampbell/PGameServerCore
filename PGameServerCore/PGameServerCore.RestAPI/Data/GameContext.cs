using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PGameServerCore.Shared.Entities;

namespace PGameServerCore.RestAPI.Models
{
    public class GameContext : DbContext
    {
        public GameContext (DbContextOptions<GameContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
    }
}
