using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class AncestrySize : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Space { get; set; }

        public int HeightReach { get; set; }

        public int BreadthReach { get; set; }

        public ICollection<Ancestry> Ancestries { get; set; } = new List<Ancestry>();

        public ICollection<Eidolon> Eidolons { get; set; } = new List<Eidolon>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class AncestrySizeSearchConfigurator : SearchableEntityConfigurator<AncestrySize>
    {
        public override Expression<Func<AncestrySize, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
