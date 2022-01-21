using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InstinctAbilities.Instances
{
    public class SuperstitiousResilience : Template
    {
        public static readonly Guid ID = Guid.Parse("be71862e-374c-4bf1-9753-89303275d2d0");
        
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
                Id = Guid.Parse("7700a678-dc98-4d3d-be04-d499b9c549e7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 108
            };
        }
    }
}
