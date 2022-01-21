using NpgsqlTypes;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class AttackType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class AttackTypeConfigurator : EntityConfigurator<AttackType>
	{
		public AttackTypeConfigurator()
		{
			ConfigureEntitySearch<AttackType>(e => new {e.Name});
		}
	}
}
