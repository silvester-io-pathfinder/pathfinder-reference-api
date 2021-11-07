using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class RuneMagic : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid InitialRuneSpellId { get; set; }
        public Spell InitialRuneSpell { get; set; } = default!;

        public Guid AdvancedRuneSpellId { get; set; }
        public Spell AdvancedRuneSpell { get; set; } = default!;

        public Guid EffectId { get; set; }
        public BooleanEffect Effect { get; set; } = default!;

        public Guid MagicSchoolId{ get; set; }
        public MagicSchool MagicSchool { get; set; } = default!;

        public ICollection<MagicSchool> ProhibitedSchools { get; set; } = new List<MagicSchool>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
