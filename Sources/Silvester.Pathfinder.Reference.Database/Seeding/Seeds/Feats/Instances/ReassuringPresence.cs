using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReassuringPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("27919a98-1773-4e01-8a89-53c012fc0dee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reassuring Presence",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet gains the frightened condition.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b66e18ca-4e08-48ae-9da9-102b2b27a213"), Type = TextBlockType.Text, Text = "You serve as an anchor to your close companions, calming them in times of stress. Decrease the value of the triggering ally’s frightened condition by 1. The ally is then temporarily immune to your Reassuring Presence for 1 hour." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("994e3a8f-0521-470b-aabf-0cb2467ff4f1"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
