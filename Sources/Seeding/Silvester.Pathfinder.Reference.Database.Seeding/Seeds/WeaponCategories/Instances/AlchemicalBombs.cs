using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances
{
    public class AlchemicalBombs : Template
    {
        public static readonly Guid ID = Guid.Parse("7a8b9674-5986-43c2-970a-cc0e7ef02a86");

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
