using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Background : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public Guid? PrerequisiteId { get; set; }
        public BooleanPrerequisite? Prerequisite { get; set; }

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class BackgroundConfigurator : EntityConfigurator<Background>
	{
		public BackgroundConfigurator()
		{
			ConfigureEntitySearch<Background>(e => new {e.Name});
		}
	}
}
