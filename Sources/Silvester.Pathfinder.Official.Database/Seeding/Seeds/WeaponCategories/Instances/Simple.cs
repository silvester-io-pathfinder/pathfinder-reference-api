using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.MeleeWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances
{
    public class Simple : AbstractWeaponCategoriesTemplate
    {
        public static readonly Guid ID = Guid.Parse("59366b6b-ef53-4be4-97e4-2311301393bd");

        protected override WeaponCategory GetWeaponCategory()
        {
            return new WeaponCategory
            {
                Id = ID,
                Name = "Simple"
            };
        }
    }
}
