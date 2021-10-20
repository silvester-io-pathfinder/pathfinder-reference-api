using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class DruidicOrder : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<DruidicOrderEffectBinding> Effects { get; set; } = new List<DruidicOrderEffectBinding>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
