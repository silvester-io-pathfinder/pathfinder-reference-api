using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups.Instances
{
    public class MediumArmor : AbstractArmorGroupTemplate
    {
        public static readonly Guid ID = Guid.Parse("199f2e7d-5249-45ee-af4d-b3f7cdd257b8");

        protected override ArmorGroup GetArmorGroup()
        {
            return new ArmorGroup 
            {
                Id = ID,
                Name = "Medium Armor" 
            };
        }
    }
}
