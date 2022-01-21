using NpgsqlTypes;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Rule : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class RuleConfigurator : EntityConfigurator<Rule>
	{
		public RuleConfigurator()
		{
			ConfigureEntitySearch<Rule>(e => new {e.Name});
		}
	}
}
