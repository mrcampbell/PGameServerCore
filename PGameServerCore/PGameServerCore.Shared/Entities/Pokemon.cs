using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PGameServerCore.Shared.Entities
{
    public class Pokemon
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int BreedNum { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public Guid TrainerId { get; set; }

        [ForeignKey("TrainerId")]
        public Trainer Trainer { get; set; }

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
