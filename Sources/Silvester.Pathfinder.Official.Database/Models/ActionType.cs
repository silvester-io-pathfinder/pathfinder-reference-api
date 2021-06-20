using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ActionType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();
        
        public ICollection<Feat> Feats { get; set; } = new List<Feat>();
     
        public ICollection<Action> Actions{ get; set; } = new List<Action>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
