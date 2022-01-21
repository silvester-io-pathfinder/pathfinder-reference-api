using NpgsqlTypes;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ConditionCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Condition> Conditions { get; set; } = new List<Condition>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ConditionCategoryConfigurator : EntityConfigurator<ConditionCategory>
	{
		public ConditionCategoryConfigurator()
		{
			ConfigureEntitySearch<ConditionCategory>(e => new {e.Name});
		}
	}
}
