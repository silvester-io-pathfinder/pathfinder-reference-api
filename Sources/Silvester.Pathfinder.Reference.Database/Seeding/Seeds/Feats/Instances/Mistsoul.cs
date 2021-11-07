using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Mistsoul : Template
    {
        public static readonly Guid ID = Guid.Parse("2e98b595-3bc9-4439-b2da-f25a0113eb9f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mistsoul",
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
            yield return new TextBlock { Id = Guid.Parse("94d7d17b-1af6-4eee-a749-80f496acf5a1"), Type = TextBlockType.Text, Text = "You have a connection to vaporous forms of water, such as fog and mist. You gain the (feat: Mist Blending) reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0f5bdb2-b8c6-48f9-8708-e3bc84dbe871"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
