using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BuiltInTools : Template
    {
        public static readonly Guid ID = Guid.Parse("fa35dde3-405b-4c50-8347-d9c7d9e23d87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Built-In Tools",
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
            yield return new TextBlock { Id = Guid.Parse("5ddd6a71-3243-4f22-9a5b-1b277f137846"), Type = TextBlockType.Text, Text = "You’ve built tools into your innovation so you can access and use them easily. When you take this feat, choose up to two sets of tools you own, such as (item: thieves’ tools) or (item: healer’s tools), that weigh a total of 2 Bulk or less. These tools become part of your innovation. The innovation’s Bulk doesn’t increase from this addition. As long as you are wielding, wearing, or adjacent to your innovation, you have the same quick access to these tools as the tools you are wearing, and they don’t count against the usual limit of tools you can wear." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c83f6978-185a-43b2-86f1-8c690e5482cc"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
