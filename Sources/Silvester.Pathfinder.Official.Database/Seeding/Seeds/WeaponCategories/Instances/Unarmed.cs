using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.MeleeWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances
{
    public class Unarmed : AbstractWeaponCategoriesTemplate
    {
        public static readonly Guid ID = Guid.Parse("9cfcad6d-a7e2-4833-ba41-86d88bee6fc7");

        protected override WeaponCategory GetWeaponCategory()
        {
            return new WeaponCategory
            {
                Id = ID,
                Name = "Unarmed"
            };
        }
    }
}
