using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Daywalker : Template
    {
        public static readonly Guid ID = Guid.Parse("2644fb87-aa23-4f87-a856-4c318431b928");

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
            yield return new TextBlock { Id = Guid.Parse("e4302e7f-a8fd-40ab-aca5-7aa5c49119d7"), Type = TextBlockType.Text, Text = "Whether through painstaking exposure, devoted prayer, or simple luck, you've found a greater affinity for life through the sun's light. When in an area of direct natural sunlight, your negative healing is suppressed, meaning you are healed by positive healing effects and harmed by negative energy." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("353ffba5-412f-4453-908e-a8f070957830"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
