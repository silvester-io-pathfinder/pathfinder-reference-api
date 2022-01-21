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
    public class Feat : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public bool CanBeLearnedMoreThanOnce { get; set; }

        public string? Special { get; set; } = default!;

        public string? Trigger { get; set; } = default!;

        public string? Frequency { get; set; }

        public string? Requirements { get; set; }

        public int Level { get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid? RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public Guid? PrerequisiteId { get; set; }
        public BooleanPrerequisite? Prerequisite { get; set; }

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class FeatConfigurator : EntityConfigurator<Feat>
	{
		public FeatConfigurator()
		{
			ConfigureEntitySearch<Feat>(e => new {e.Name});
		}
	}
}
