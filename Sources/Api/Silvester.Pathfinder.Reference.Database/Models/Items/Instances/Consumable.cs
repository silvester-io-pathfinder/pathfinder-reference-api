using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class Consumable : BaseItem
    {

    }

    public class ConsumableVariant : BaseItemVariant, IUsed, ISearchableEntity
    {
        public int Price { get; set; }
        public int Level { get; set; }
        public string Usage { get; set; } = default!;
        public string? Hands { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ConsumableVariantConfigurator : EntityConfigurator<ConsumableVariant>
	{
		public ConsumableVariantConfigurator()
		{
			ConfigureEntitySearch<ConsumableVariant>(e => new {e.Name, e.Usage});
		}
	}
}
