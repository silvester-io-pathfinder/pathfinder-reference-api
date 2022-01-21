using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class WeaponGroup : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string CriticalEffect { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<MeleeWeapon> MeleeWeapons { get; set; } = new List<MeleeWeapon>();
        public ICollection<RangedWeapon> RangedWeapons { get; set; } = new List<RangedWeapon>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class WeaponGroupConfigurator : EntityConfigurator<WeaponGroup>
	{
		public WeaponGroupConfigurator()
		{
			ConfigureEntitySearch<WeaponGroup>(e => new {e.Name, e.CriticalEffect});
		}
	}
}
