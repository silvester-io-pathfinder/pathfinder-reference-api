using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InstinctAbilities.Instances
{
    public class DraconicRage : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
