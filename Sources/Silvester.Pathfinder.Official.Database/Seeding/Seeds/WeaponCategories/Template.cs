using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories
{
    public abstract class Template : EntityTemplate<WeaponCategory>
    {
        protected override WeaponCategory GetEntity(ModelBuilder builder)
        {
            WeaponCategory weaponCategory = GetWeaponCategory();
            return weaponCategory;
        }

        protected abstract WeaponCategory GetWeaponCategory();
    }
}
