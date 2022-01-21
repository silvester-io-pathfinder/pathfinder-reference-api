using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class Ammunition : BaseItem, INamedEntity
    {
        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;
    }

    public class AmmunitionVariant : BaseItemVariant, ISearchableEntity
    {
        public int Price { get; set; }

        public int BatchAmount { get; set; }
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class AmmunitionVariantConfigurator : EntityConfigurator<AmmunitionVariant>
	{
		public AmmunitionVariantConfigurator()
		{
			ConfigureEntitySearch<AmmunitionVariant>(e => new {e.Name});
		}
	}
}
