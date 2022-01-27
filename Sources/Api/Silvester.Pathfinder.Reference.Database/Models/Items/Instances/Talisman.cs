using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class Talisman : BaseItem
    {

    }

    public class TalismanVariant : BaseItemVariant, IUsed, ISearchableEntity
    {
        public int Price { get; set; }
        public int Level { get; set; }
        public string Usage { get; set; } = default!;
        public string? Hands { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class TalismanVariantConfigurator : EntityConfigurator<TalismanVariant>
	{
		public TalismanVariantConfigurator()
		{
			ConfigureEntitySearch<TalismanVariant>(e => new {e.Name, e.Usage});
		}
	}
}
