using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class SavingThrowStat : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class SavingThrowStatConfigurator : EntityConfigurator<SavingThrowStat>
	{
		public SavingThrowStatConfigurator()
		{
			ConfigureEntitySearch<SavingThrowStat>(e => new {e.Name});
		}
	}
}
