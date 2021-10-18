using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InstinctAbilities.Instances
{
    public class SuperstitiousResilience : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override InstinctAbility GetInstinctAbility()
        {
            return new InstinctAbility
            {
                Id = ID, 
                Name = "Superstitious Resilience",
                Description = "While raging, you gain a +2 status bonus to all saves against magic. Increase your damage from Rage from 2 to 4 against creatures that can cast spells. Once every 10 minutes, when you Rage, you regain Hit Points equal to the temporary Hit Points you gain from that Rage action.",
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 108
            };
        }
    }
}
