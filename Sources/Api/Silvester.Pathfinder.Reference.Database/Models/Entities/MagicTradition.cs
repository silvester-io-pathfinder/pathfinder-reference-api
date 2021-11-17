using NpgsqlTypes;
using System;

using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class MagicTradition : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class MagicTraditionSearchConfigurator : SearchableEntityConfigurator<MagicTradition>
    {
        public override Expression<Func<MagicTradition, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
