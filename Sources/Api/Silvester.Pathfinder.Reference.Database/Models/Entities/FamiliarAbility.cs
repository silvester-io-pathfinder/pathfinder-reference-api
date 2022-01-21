using NpgsqlTypes;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class FamiliarAbility : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class FamiliarAbilityConfigurator : EntityConfigurator<FamiliarAbility>
	{
		public FamiliarAbilityConfigurator()
		{
			ConfigureEntitySearch<FamiliarAbility>(e => new {e.Name, e.Description});
		}
	}
}
