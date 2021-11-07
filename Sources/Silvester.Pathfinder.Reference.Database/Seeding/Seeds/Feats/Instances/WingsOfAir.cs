using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WingsOfAir : Template
    {
        public static readonly Guid ID = Guid.Parse("1ee6bd27-89fe-42b1-9bd3-328a9e6fbf12");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wings of Air",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c93b99a-921f-4e1f-8cd8-c20d1661251c"), Type = TextBlockType.Text, Text = "You can strain to call forth feathered or cloudy wings from your back. Once manifested, these wings remain for 10 minutes. You gain a fly Speed equal to your land Speed while you’ve manifested your wings." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d5dfa8a-5561-42f6-ac17-4ca824f16cfe"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
