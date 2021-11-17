using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class EffectArea : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<DraconicExemplar> DraconicExemplars { get; set; } = new List<DraconicExemplar>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class EffectAreaSearchConfigurator : SearchableEntityConfigurator<EffectArea>
    {
        public override Expression<Func<EffectArea, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
