using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Action : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string? Trigger { get; set; } 

        public string? Requirements { get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; }

        public ICollection<ActionDetailsBlock> Details { get; set; } = new List<ActionDetailsBlock>();
        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
    }
}
