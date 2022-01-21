using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Potency : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Order { get; set; }

        public ICollection<AlchemicalBombVariant> AlchemicalBombs { get; set; } = new List<AlchemicalBombVariant>();
        public ICollection<AlchemicalToolVariant> AlchemicalTools { get; set; } = new List<AlchemicalToolVariant>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PotencyConfigurator : EntityConfigurator<Potency>
	{
		public PotencyConfigurator()
		{
			ConfigureEntitySearch<Potency>(e => new {e.Name});
		}
	}
}
