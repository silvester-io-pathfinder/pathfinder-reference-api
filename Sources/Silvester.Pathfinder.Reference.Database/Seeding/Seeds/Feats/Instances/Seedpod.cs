using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Seedpod : Template
    {
        public static readonly Guid ID = Guid.Parse("de17dee3-64f9-4511-911c-c7b22fa6e5f4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Seedpod",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c3c15e5-509e-4150-8b44-c9a6d3d6c8a5"), Type = TextBlockType.Text, Text = "Your body produces a nearly endless supply of hard seedpods. You gain a seedpod ranged unarmed attack that deals 1d4 bludgeoning damage; these (action: Strikes | Strike) have the manipulate trait. On a critical hit, a seedpod bursts, issuing forth a tangle of vegetation that imposes a -10-foot circumstance penalty on the target’s Speed for 1 round. Seedpods do not add critical specialization effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4eaa892-d810-4762-9124-e02780cde350"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
