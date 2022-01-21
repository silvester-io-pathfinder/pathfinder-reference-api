using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Action : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string? Trigger { get; set; }

        public string? Requirements { get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid? RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; }

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ActionConfigurator : EntityConfigurator<Models.Entities.Action>
	{
		public ActionConfigurator()
		{
			ConfigureEntitySearch<Models.Entities.Action>(e => new {e.Name, e.Requirements, e.Trigger});
		}
	}
}
