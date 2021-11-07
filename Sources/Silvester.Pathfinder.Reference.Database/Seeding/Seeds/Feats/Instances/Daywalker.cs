using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Daywalker : Template
    {
        public static readonly Guid ID = Guid.Parse("f353246c-8009-4345-91ff-00c8bfc90ab6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Daywalker",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("57f4eefa-9ce4-4dc1-82ad-943426180430"), Type = TextBlockType.Text, Text = "Whether through painstaking exposure, devoted prayer, or simple luck, you’ve found a greater affinity for life through the sun’s light. When in an area of direct natural sunlight, your negative healing is suppressed, meaning you are healed by positive healing effects and harmed by negative energy." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5191fcb-0713-4799-9118-c0e0b081cb03"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
