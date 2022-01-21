using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances
{
    public class Simple : Template
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
