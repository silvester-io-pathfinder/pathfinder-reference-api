using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReadDisaster : Template
    {
        public static readonly Guid ID = Guid.Parse("af492aa2-59a9-4f3a-93a6-67a1fad3bb9e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Read Disaster",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5344c5ad-7fbe-4952-9980-f01d9b00f5fd"), Type = TextBlockType.Text, Text = "You spend 10 minutes and open yourself to the divine mysteries of the world, peering into the most sinister portents of the future. You gain the effects of (spell: augury), except you learn only about the dangers ahead; any results of “weal” are instead “nothing,” and results of “weal and woe” are instead “woe.” If you are legendary in Religion, you take only 1 minute to Read Disaster." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("200cdd13-5b5f-4e7a-a85c-805fa06011dc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
