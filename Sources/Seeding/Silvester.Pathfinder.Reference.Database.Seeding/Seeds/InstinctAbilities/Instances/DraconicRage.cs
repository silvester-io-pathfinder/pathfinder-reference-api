using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InstinctAbilities.Instances
{
    public class DraconicRage : Template
    {
        public static readonly Guid ID = Guid.Parse("f56db9a2-3ed5-480c-b9d7-851e05806d03");
        
        protected override InstinctAbility GetInstinctAbility()
        {
            return new InstinctAbility
            {
                Id = ID, 
                Name = "Draconic Rage",
                Description = "While raging, you can increase the additional damage from Rage from 2 to 4 and change its damage type to match that of your dragon's breath weapon instead of the damage type for your weapon or unarmed attack. If you do this, your Rage action gains the arcane and evocation traits, as well as the trait matching the damage type.",
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90ec2d73-31b5-4f64-a3c6-618300cd76e3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
