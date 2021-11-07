using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstantReturn : Template
    {
        public static readonly Guid ID = Guid.Parse("2c12ce9d-da88-4596-b445-2b25d095944a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instant Return",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy misses you with a ranged attack using a type of ammunition appropriate to your weapon (a bullet if you're wielding a firearm).",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5800790-0210-4c6e-8d57-5bf30da90088"), Type = TextBlockType.Text, Text = "With a single fluid gesture, you catch a projectile out of the air, load it in your weapon, and shoot it back at the attacker. (action: Interact) to load the projectile into your weapon, then make a (action: Strike) with the required weapon against the triggering opponent. Since you’re using the foe’s ammunition, this (action: Strike) applies any special effects that ammunition would have (for instance, if it was (item: explosive ammunition), it would explode in a burst of fire if your (action: Strike) hits)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecc8d9c3-8eb3-42b4-9b3f-d2b71f2d1cb4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
