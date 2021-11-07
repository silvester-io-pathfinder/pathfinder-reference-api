using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SilentStep : Template
    {
        public static readonly Guid ID = Guid.Parse("a0af9640-5d81-41c2-83d8-ee2532448ea0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Silent Step",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44d8a069-1977-41e6-a886-fb3e95cbeb57"), Type = TextBlockType.Text, Text = "You vanish with silent treads. You (action: Step), then (action: Hide) or (action: Sneak). You still need to meet the requirements to (action: Hide) or (action: Sneak), as normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04a660b8-7f0b-4772-a6ee-f9b23a9bcf61"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
