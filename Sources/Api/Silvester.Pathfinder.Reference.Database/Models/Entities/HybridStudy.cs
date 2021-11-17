using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class HybridStudy : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid ConfluxSpellId { get; set; }
        public Spell ConfluxSpell { get; set; } = default!;

        public Guid SeventhSpellId { get; set; }
        public Spell SeventhSpell { get; set; } = default!;

        public Guid EleventhSpellId { get; set; }
        public Spell EleventhSpell { get; set; } = default!;

        public Guid ThirteenthSpellId { get; set; }
        public Spell ThirteenthSpell { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class HybridStudySearchConfigurator : SearchableEntityConfigurator<HybridStudy>
    {
        public override Expression<Func<HybridStudy, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
