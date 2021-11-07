using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChannelTheGodmind : Template
    {
        public static readonly Guid ID = Guid.Parse("4b9f8822-033f-43c2-8f5d-2db4d25c44e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Channel the Godmind",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da3eb2dc-e9ff-408d-8f14-7ed1cf254068"), Type = TextBlockType.Text, Text = "You tap into the Godmind’s collective cognitive well, rapidly parsing near-infinite variables to read your surroundings. For 1 minute, you gain precise motion sense out to 60 feet, you can see invisible creatures and objects, and you gain the effects of a 9th-level (spell: true seeing)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0d5fce0-49ba-4e5a-b55e-1dc372ae2fab"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
