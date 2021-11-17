using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class SpellComponent : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class SpellComponentSearchConfigurator : SearchableEntityConfigurator<SpellComponent>
    {
        public override Expression<Func<SpellComponent, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
