using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cringe : Template
    {
        public static readonly Guid ID = Guid.Parse("7076af5e-f912-4f76-a78d-e6b365e9528a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cringe",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature you are aware of critically succeeds on a Strike against you and would deal damage to you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a46c2d09-0218-408d-bec1-f0feb86a5ae1"), Type = TextBlockType.Text, Text = "With pitiful posturing, you cause your foe to pull back a deadly attack. The attacking creature takes a circumstance penalty to the damage of the triggering (action: Strike) equal to your level + 2. This penalty applies after doubling the damage for a critical hit. The attacker is then immune to your Cringe for 24 hours." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce32fea3-9501-47d1-bbc0-c3f16e0efd18"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
