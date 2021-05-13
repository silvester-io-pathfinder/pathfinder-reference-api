using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorCategories;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorCategories.Instances
{
    public class LightArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("28f6b905-0c5e-4cc0-8164-8e623fdfb367");

        protected override ArmorCategory GetArmorCategory()
        {
            return new ArmorCategory
            {
                Id = ID,
                Name = "Light Armor"
            };
        }
    }
}
