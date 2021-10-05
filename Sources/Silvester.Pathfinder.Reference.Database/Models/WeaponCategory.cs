using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class WeaponCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<MeleeWeapon> MeleeWeapons { get; set; } = new List<MeleeWeapon>();
        public ICollection<RangedWeapon> RangedWeapons { get; set; } = new List<RangedWeapon>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
