using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Methodology : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<MethodologyEffectBinding> Effects { get; set; } = new List<MethodologyEffectBinding>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
