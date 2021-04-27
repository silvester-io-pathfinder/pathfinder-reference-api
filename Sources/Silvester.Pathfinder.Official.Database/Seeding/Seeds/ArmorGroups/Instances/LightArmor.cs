using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups.Instances
{
    public class LightArmor : AbstractArmorGroupTemplate
    {
        public static readonly Guid ID = Guid.Parse("28f6b905-0c5e-4cc0-8164-8e623fdfb367");

        protected override ArmorGroup GetArmorGroup()
        {
            return new ArmorGroup 
            {
                Id = ID,
                Name = "Light Armor" 
            };
        }
    }
}
