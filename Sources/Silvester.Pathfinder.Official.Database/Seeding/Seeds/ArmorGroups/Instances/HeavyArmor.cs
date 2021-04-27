using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups.Instances
{
    public class HeavyArmor : AbstractArmorGroupTemplate
    {
        public static readonly Guid ID = Guid.Parse("f3d2b25b-e222-4af2-9287-a6036e6bb0b7");

        protected override ArmorGroup GetArmorGroup()
        {
            return new ArmorGroup 
            {
                Id = ID,
                Name = "Heavy Armor"
            };
        }
    }
}
