using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WrongedMonksWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("972ece16-cf8f-4ff0-b7c5-8ba27b201a3f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wronged Monk's Wrath",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("986c04b4-4e59-4aeb-9198-62040752f2f5"), Type = TextBlockType.Text, Text = "You gain the (spell: wronged monk&#39;s wrath) ki spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ca950d3-61ad-4e8c-9343-23273177cabd"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
