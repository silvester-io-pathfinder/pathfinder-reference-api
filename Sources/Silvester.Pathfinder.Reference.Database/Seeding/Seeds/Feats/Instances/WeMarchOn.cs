using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WeMarchOn : Template
    {
        public static readonly Guid ID = Guid.Parse("aa970d91-c2a5-4e52-abb9-f7219a36b205");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "We March On",
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
            yield return new TextBlock { Id = Guid.Parse("bcf4cceb-97c1-4966-a864-4af1f356b120"), Type = TextBlockType.Text, Text = "You make sure that your allies push themselves while traveling. You gain the (feat: Caravan Leader) and (feat: Pick Up the Pace) general feats, even if you don’t meet the prerequisites." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66771d50-48b9-4f12-a95f-5a1325b78768"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
