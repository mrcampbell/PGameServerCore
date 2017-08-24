using System;
using System.Collections.Generic;
using System.Text;

namespace PGameServerCore.Shared.Entities
{
    public class Trainer
    {
        public Guid Id { get; set; }
        public string Username { get; set; }

        // for referencing login/actual user data
        public Guid UserId { get; set; }
        public User User { get; set; }

        public int Level { get; set; }

        public ICollection<Pokemon> Pokemon
            = new List<Pokemon>();
    }
}
