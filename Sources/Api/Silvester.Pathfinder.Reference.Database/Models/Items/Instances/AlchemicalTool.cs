using System;
using System.Linq.Expressions;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class AlchemicalTool : BaseItem
    {

    }

    public class AlchemicalToolVariant : BaseItemVariant, IUsed, ISearchableEntity
    {
        public int Level { get; set; }
        public int Price { get; set; }
        public string Usage { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class AlchemicalToolVariantConfigurator : EntityConfigurator<AlchemicalToolVariant>
	{
		public AlchemicalToolVariantConfigurator()
		{
			ConfigureEntitySearch<AlchemicalToolVariant>(e => new {e.Name, e.Usage});
		}
	}
}
