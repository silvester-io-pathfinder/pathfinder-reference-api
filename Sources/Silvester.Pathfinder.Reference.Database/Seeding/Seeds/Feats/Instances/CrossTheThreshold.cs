using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrossTheThreshold : Template
    {
        public static readonly Guid ID = Guid.Parse("6d98bb21-8c18-4262-b57a-cbc71352a711");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cross the Threshold",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a0e75c5-1b4c-43b1-af77-5da4df6aa224"), Type = TextBlockType.Text, Text = "You can cast (spell: ethereal jaunt) as an occult innate spell once per day. You don&#39;t need to (activity: Sustain the Spell | Sustain a Spell); instead, it lasts for 10 minutes or until you choose to return to your material form as a free action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34e40b0c-efb2-40e2-a67e-963681c16370"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
