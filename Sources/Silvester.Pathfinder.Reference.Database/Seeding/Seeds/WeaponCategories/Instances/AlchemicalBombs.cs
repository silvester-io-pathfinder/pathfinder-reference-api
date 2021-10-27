using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances
{
    public class AlchemicalBombs : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override WeaponCategory GetWeaponCategory()
        {
            return new WeaponCategory
            {
                Id = ID,
                Name = "Alchemical Bombs"
            };
        }
    }
}
