using NpgsqlTypes;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class HarrowMode : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class HarrowModeConfigurator : EntityConfigurator<HarrowMode>
	{
		public HarrowModeConfigurator()
		{
			ConfigureEntitySearch<HarrowMode>(e => new {e.Name});
		}
	}
}
