using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Rarity : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Ancestry> Ancestries { get; set; } = new List<Ancestry>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class RaritySearchConfigurator : SearchableEntityConfigurator<Rarity>
    {
        public override Expression<Func<Rarity, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
