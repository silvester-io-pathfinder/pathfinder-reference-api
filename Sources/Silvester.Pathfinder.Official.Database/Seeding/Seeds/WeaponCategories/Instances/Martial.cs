using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.MeleeWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponCategories.Instances
{
    public class Martial : Template
    {
        public static readonly Guid ID = Guid.Parse("2f7d0afa-d5fd-4b5a-96ae-94d0d788448f");

        protected override WeaponCategory GetWeaponCategory()
        {
            return new WeaponCategory
            {
                Id = ID,
                Name = "Martial"
            };
        }
    }
}
