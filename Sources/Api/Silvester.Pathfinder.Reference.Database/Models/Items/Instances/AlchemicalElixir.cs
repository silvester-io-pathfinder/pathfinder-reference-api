using System;
using System.Linq.Expressions;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class AlchemicalElixir : BaseItem
    {
        public string? Benefit { get; set; }
        public string? Drawback { get; set; }
    }

    public class AlchemicalElixirVariant : BaseItemVariant, IUsed, ISearchableEntity
    {
        public int Price { get; set; }
        public int Level { get; set; }
        public string Usage { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class AlchemicalElixirVariantConfigurator : EntityConfigurator<AlchemicalElixirVariant>
	{
		public AlchemicalElixirVariantConfigurator()
		{
			ConfigureEntitySearch<AlchemicalElixirVariant>(e => new {e.Name, e.Usage});
		}
	}
}
