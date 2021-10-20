using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class HybridStudy : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public Spell SourcePage { get; set; } = default!;

        public Guid ConfluxSpellId { get; set; }
        public Spell ConfluxSpell { get; set; } = default!;

        public Guid SeventhSpellId { get; set; }
        public Spell SeventhSpell { get; set; } = default!;

        public Guid EleventhSpellId { get; set; }
        public Spell EleventhSpell { get; set; } = default!;

        public Guid ThirteenthSpellId { get; set; }
        public Spell ThirteenthSpell { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<HybridStudyEffectBinding> Effects { get; set; } = new List<HybridStudyEffectBinding>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
