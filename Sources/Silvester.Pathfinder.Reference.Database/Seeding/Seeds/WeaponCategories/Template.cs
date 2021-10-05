using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories
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
