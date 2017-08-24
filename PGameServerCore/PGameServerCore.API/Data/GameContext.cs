using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PGameServerCore.Shared.Entities;

namespace PGameServerCore.API.Models
{
    public class GameContext : DbContext
    {
        public GameContext (DbContextOptions<GameContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }

        public void EnsureSeedDataCreated()
        {
            Trainers.Add(new Trainer() { Id = new Guid("8B176CF0-D3E4-4C5E-93DC-CF9F793040AC"), Username = "Mikeymikemike75" });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Trainer>().ToTable("dbo.Trainer");
        }
    }
}
