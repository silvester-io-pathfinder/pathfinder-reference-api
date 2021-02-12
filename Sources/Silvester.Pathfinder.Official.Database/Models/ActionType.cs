using Silvester.Pathfinder.Official.Database;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ActionType : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();
        
        public ICollection<Feat> Feats { get; set; } = new List<Feat>();
    }
}
