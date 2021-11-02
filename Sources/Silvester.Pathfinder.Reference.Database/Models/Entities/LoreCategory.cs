using NpgsqlTypes;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class LoreCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public virtual string Name { get; set; } = default!;
        public string Examples { get; set; } = default!;
        public string Description { get; set; } = default!;

        public Guid StatModifierId { get; set; }
        public Stat StatModifier { get; set; } = default!;
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}