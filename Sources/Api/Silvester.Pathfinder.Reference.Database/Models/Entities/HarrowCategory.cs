using NpgsqlTypes;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class HarrowCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Effects { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid AffectedStatId { get; set; }
        public Stat AffectedStat { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class HarrowCategoryConfigurator : EntityConfigurator<HarrowCategory>
	{
		public HarrowCategoryConfigurator()
		{
			ConfigureEntitySearch<HarrowCategory>(e => new {e.Name, e.Effects, e.Description});
		}
	}
}
