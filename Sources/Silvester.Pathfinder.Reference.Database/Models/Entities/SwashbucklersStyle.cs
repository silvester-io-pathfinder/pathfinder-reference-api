using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class SwashbucklersStyle : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string ExemplaryFinisher { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid EffectId { get; set; }
        public BooleanEffect Effect { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
