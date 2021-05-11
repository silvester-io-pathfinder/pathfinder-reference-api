using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorCategories;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorCategories.Instances
{
    public class Unarmored : AbstractArmorGroupTemplate
    {
        public static readonly Guid ID = Guid.Parse("3e53fcd2-e07b-4af5-b331-b4372acacf74");

        protected override ArmorCategory GetArmorCategory()
        {
            return new ArmorCategory
            {
                Id = ID,
                Name = "Unarmored"
            };
        }
    }
}
