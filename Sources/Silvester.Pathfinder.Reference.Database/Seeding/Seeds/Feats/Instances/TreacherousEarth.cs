using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TreacherousEarth : Template
    {
        public static readonly Guid ID = Guid.Parse("c5911649-2314-4280-9380-a1dc0d1499b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Treacherous Earth",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once every 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("35fdfd33-4313-4f26-9892-a1c9030d0f17"), Type = TextBlockType.Text, Text = "You have the power to shatter the earth into a shape of your devising. You crack the ground beneath you, creating difficult terrain in a 5-foot burst centered on one corner of your space." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8804255f-4f5c-44c7-990b-7f7be86270d7"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
