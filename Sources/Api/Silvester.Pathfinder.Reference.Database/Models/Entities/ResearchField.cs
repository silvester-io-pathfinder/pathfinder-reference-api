using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ResearchField : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ResearchFieldSearchConfigurator : SearchableEntityConfigurator<ResearchField>
    {
        public override Expression<Func<ResearchField, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
