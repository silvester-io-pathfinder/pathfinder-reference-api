using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances
{
    public class Advanced : Template
    {
        public static readonly Guid ID = Guid.Parse("f2115c27-5192-40f2-a41a-3ddbb8cb16b2");

        protected override WeaponCategory GetWeaponCategory()
        {
            return new WeaponCategory
            {
                Id = ID,
                Name = "Advanced"
            };
        }
    }
}
