using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class SpellType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description{ get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class SpellTypeSearchConfigurator : SearchableEntityConfigurator<SpellType>
    {
        public override Expression<Func<SpellType, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
