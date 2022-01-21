using System;
using System.Linq.Expressions;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class BeastGun : BaseItem
    {
        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;

        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }

    public class BeastGunVariant : BaseItemVariant, ISearchableEntity
    {
        public int Level { get; set; }
        public int Price { get; set; }
        public string Hands { get; set; } = default!;
        public int Range { get; set; }
        public int? Reload { get; set; }
        public string Damage { get; set; } = default!;
        public int Capacity { get; set; }

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class BeastGunVariantConfigurator : EntityConfigurator<BeastGunVariant>
	{
		public BeastGunVariantConfigurator()
		{
			ConfigureEntitySearch<BeastGunVariant>(e => new {e.Name});
		}
	}
}
