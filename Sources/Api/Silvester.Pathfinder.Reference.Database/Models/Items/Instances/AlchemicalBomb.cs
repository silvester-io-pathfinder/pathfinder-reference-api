using System;
using System.Linq.Expressions;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class AlchemicalBomb : BaseItem
    {
        public string Benefit { get; set; } = default!;
        public string Drawback { get; set; } = default!;
    }

    public class AlchemicalBombVariant : BaseItemVariant, IUsed, ISearchableEntity
    {
        public int Level { get; set; }
        public int Price { get; set; }
        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;
        public string Usage { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class AlchemicalBombVariantConfigurator : EntityConfigurator<AlchemicalBombVariant>
	{
		public AlchemicalBombVariantConfigurator()
		{
			ConfigureEntitySearch<AlchemicalBombVariant>(e => new {e.Name, e.Usage});
		}
	}
}
