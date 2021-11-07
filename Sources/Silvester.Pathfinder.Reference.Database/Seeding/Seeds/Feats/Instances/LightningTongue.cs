using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LightningTongue : Template
    {
        public static readonly Guid ID = Guid.Parse("e982c918-a097-464a-abd6-7b0eb79a0478");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lightning Tongue",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8894f9b5-b83e-4076-a631-72ab9898faf8"), Type = TextBlockType.Text, Text = "Your tongue darts out faster than the eye can see to retrieve loose objects. You (action: Interact) to pick up a single unattended object of light Bulk or less within 10 feet of you. If you don’t have enough hands free to hold the object, it falls to the ground in your space." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad97d03f-5c6f-4b90-a6de-6f1c9df696af"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
