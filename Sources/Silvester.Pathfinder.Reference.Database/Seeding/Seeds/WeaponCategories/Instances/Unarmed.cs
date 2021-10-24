using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances
{
    public class Unarmed : Template
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
