using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System.Linq.Expressions;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class DamageType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DamageTypeConfigurator : EntityConfigurator<DamageType>
	{
		public DamageTypeConfigurator()
		{
			ConfigureEntitySearch<DamageType>(e => new {e.Name});
		}
	}
}
