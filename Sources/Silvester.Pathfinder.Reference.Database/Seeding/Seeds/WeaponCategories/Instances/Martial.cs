using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances
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
