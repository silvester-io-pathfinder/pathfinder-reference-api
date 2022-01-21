using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class WeaponCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<MeleeWeapon> MeleeWeapons { get; set; } = new List<MeleeWeapon>();
        public ICollection<RangedWeapon> RangedWeapons { get; set; } = new List<RangedWeapon>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class WeaponCategoryConfigurator : EntityConfigurator<WeaponCategory>
	{
		public WeaponCategoryConfigurator()
		{
			ConfigureEntitySearch<WeaponCategory>(e => new {e.Name});
		}
	}
}
