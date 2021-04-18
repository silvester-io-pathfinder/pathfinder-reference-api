using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Curse : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public string Effect { get; set; } = default!;

        public int? Level { get; set; }

        public int? DifficultyCheck { get; set; }

        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
    }
}
