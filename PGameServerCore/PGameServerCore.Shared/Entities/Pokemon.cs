using System;
using System.Collections.Generic;
using System.Text;

namespace PGameServerCore.Shared.Entities
{
    public class Pokemon
    {
        public Guid Id { get; set; }
        public int BreedNum { get; set; }
        public string Name { get; set; }

        public Guid TrainerId { get; set; }
        public Guid Trainer { get; set; }

        public Int16 EV_HP { get; set; }
        public Int16 EV_ATK { get; set; }
        public Int16 EV_DEF { get; set; }
        public Int16 EV_SPEC_ATK { get; set; }
        public Int16 EV_SPEC_DEF { get; set; }
        public Int16 EV_SPEED { get; set; }

        public Int16 IV_HP { get; set; }
        public Int16 IV_ATK { get; set; }
        public Int16 IV_DEF { get; set; }
        public Int16 IV_SPEC_ATK { get; set; }
        public Int16 IV_SPEC_DEF { get; set; }
        public Int16 IV_SPEED { get; set; }
    }
}
