using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstantOpening : Template
    {
        public static readonly Guid ID = Guid.Parse("402dff3c-8fb8-4409-ab0c-6bc9ffa7b66f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instant Opening",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe745473-4dab-413e-9874-29c4d9d0b5de"), Type = TextBlockType.Text, Text = "You distract your opponent with a few choice words or a rude gesture. Choose a target within 30 feet. It’s flat-footed against your attacks until the end of your next turn. Depending on the way you describe your distraction, this action gains either the (trait: auditory) or (trait: visual) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54853b13-ffa9-480a-b6ee-b9cec9d6706b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
