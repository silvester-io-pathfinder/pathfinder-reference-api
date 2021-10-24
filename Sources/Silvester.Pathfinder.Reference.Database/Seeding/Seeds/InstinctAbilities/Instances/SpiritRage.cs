using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InstinctAbilities.Instances
{
    public class SpiritRage : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override InstinctAbility GetInstinctAbility()
        {
            return new InstinctAbility
            {
                Id = ID, 
                Name = "Spirit Rage",
                Description = "While raging, you can increase the additional damage from Rage from 2 to 3 and change its damage type to negative or positive, instead of the damage type for your weapon or unarmed attack (choose each time you Rage). If you choose to deal negative or positive damage, your weapon or unarmed attack gains the effects of the ghost touch property rune, which makes it more effective against incorporeal creatures, and your Rage action gains the divine and necromancy traits, plus negative or positive, as appropriate.",
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
