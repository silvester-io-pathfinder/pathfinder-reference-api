using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorCategories.Instances
{
    public class HeavyArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("f3d2b25b-e222-4af2-9287-a6036e6bb0b7");

        protected override ArmorCategory GetArmorCategory()
        {
            return new ArmorCategory
            {
                Id = ID,
                Name = "Heavy Armor"
            };
        }
    }
}
