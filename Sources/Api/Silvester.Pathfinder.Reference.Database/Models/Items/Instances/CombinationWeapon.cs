using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class CombinationWeapon : BaseItem
    {
        public Guid WeaponCategoryId { get; set; }
        public WeaponCategory WeaponCategory { get; set; } = default!;
    }

    public class CombinationWeaponVariant : BaseItemVariant, IHeld, ISearchableEntity
    {
        public int Price { get; set; }
        public string Hands { get; set; } = default!;

        public Guid RangedComponentId { get; set; }
        public CombinationWeaponRangedComponent RangedComponent { get; set; } = default!;

        public Guid MeleeComponentId { get; set; }
        public CombinationWeaponMeleeComponent MeleeComponent { get; set; } = default!;
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class CombinationWeaponVariantConfigurator : EntityConfigurator<CombinationWeaponVariant>
	{
		public CombinationWeaponVariantConfigurator()
		{
			ConfigureEntitySearch<CombinationWeaponVariant>(e => new {e.Name});
		}
	}

    public class CombinationWeaponComponent : BaseEntity
    {
        public string Damage { get; set; } = default!;

        public ICollection<CombinationWeaponComponentTraitBinding> TraitBindings { get; set; } = new List<CombinationWeaponComponentTraitBinding>();
    }

    public class CombinationWeaponComponentTraitBinding : TraitBinding<CombinationWeaponComponent>
    {

    }

    public class CombinationWeaponRangedComponent : CombinationWeaponComponent
    {
        public int Range { get; set; }
        public int? Reload { get; set; }
        public int Capacity { get; set; }

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;
    }

    public class CombinationWeaponMeleeComponent : CombinationWeaponComponent
    {
        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;
    }
}
