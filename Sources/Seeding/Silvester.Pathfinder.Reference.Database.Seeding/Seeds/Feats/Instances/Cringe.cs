using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cringe : Template
    {
        public static readonly Guid ID = Guid.Parse("3a40cb3d-f24d-4ce2-b341-01348bf18dc5");

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
            yield return new TextBlock { Id = Guid.Parse("ab9f7c89-23f5-4ecc-81b4-72a6a74a6020"), Type = TextBlockType.Text, Text = "With pitiful posturing, you cause your foe to pull back a deadly attack. The attacking creature takes a circumstance penalty to the damage of the triggering (action: Strike) equal to your level + 2. This penalty applies after doubling the damage for a critical hit. The attacker is then immune to your Cringe for 24 hours." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20526be9-b2c5-4b66-976b-09c30ca0020c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
