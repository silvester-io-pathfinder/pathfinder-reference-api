using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class PatronTheme : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid EffectId { get; set; }
        public BooleanEffect Effect { get; set; } = default!;

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public Guid MagicTraditionId { get; set; }
        public MagicTradition MagicTradition { get; set; } = default!;

        public Guid PatronSkillId { get; set; }
        public Skill PatronSkill { get; set; } = default!;

        public ICollection<Spell> GrantedSpellOptions { get; set; } = new List<Spell>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PatronThemeConfigurator : EntityConfigurator<PatronTheme>
	{
		public PatronThemeConfigurator()
		{
			ConfigureEntitySearch<PatronTheme>(e => new {e.Name, e.Description});
		}
	}
}
