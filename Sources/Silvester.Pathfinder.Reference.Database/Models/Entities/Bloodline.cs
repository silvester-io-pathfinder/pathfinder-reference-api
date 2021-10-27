using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Bloodline : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;

        public Guid SpellListTraditionId { get; set; }
        public MagicTradition SpellListTradition { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<TextBlock> TypeChoiceDetails { get; set; } = new List<TextBlock>();

        public ICollection<Skill> BloodlineSkills { get; set; } = new List<Skill>();

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public Guid InitialBloodlineSpellId { get; set; }
        public Spell InitialBloodlineSpell { get; set; } = default!;

        public Guid AdvancedBloodlineSpellId { get; set; }
        public Spell AdvancedBloodlineSpell { get; set; } = default!;

        public Guid GreaterBloodlineSpellId { get; set; }
        public Spell GreaterBloodlineSpell { get; set; } = default!;

        public Guid? RelatedBloodlineId { get; set; }
        public Bloodline? RelatedBloodline { get; set; } 

        public string BloodMagic { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
