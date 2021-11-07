using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SculptShadows : Template
    {
        public static readonly Guid ID = Guid.Parse("84bd97b1-0d56-417e-9a1a-480fea6f03a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sculpt Shadows",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0f717828-221c-4f99-8ab0-f1c66404a302"), Type = TextBlockType.Text, Text = "You coax nearby shadows into the shape of a simple weapon or a simple tool or item, using a tiny piece of your shadow to make it solid; in doing so, you lose 1 Hit Point. You can create only level-0 common, non-consumable weapons, or adventuring gear with no intricate parts, written text, or other complicated components. The item lasts until used for a single activity, until you Sculpt Shadows again, or for 1 minute, whichever comes first. Once the duration expires, the object dissipates, and you regain the lost Hit Point unless the item was Broken or Destroyed. As the object holds a tiny sliver of your shadow, you can’t recover the lost Hit Point until after the object dissipates." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07ea5bfd-da3c-407a-9588-9031fba9c0d0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
