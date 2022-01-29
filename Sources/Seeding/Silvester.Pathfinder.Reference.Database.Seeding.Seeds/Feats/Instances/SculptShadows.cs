using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SculptShadows : Template
    {
        public static readonly Guid ID = Guid.Parse("de1dfac1-2ae8-4390-9e73-10bedef9d2bc");

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
            yield return new TextBlock { Id = Guid.Parse("94cb4c23-e2d5-49c9-8c52-8e99495b2643"), Type = TextBlockType.Text, Text = $"You coax nearby shadows into the shape of a simple weapon or a simple tool or item, using a tiny piece of your shadow to make it solid; in doing so, you lose 1 Hit Point. You can create only level-0 common, non-consumable weapons, or adventuring gear with no intricate parts, written text, or other complicated components. The item lasts until used for a single activity, until you Sculpt Shadows again, or for 1 minute, whichever comes first. Once the duration expires, the object dissipates, and you regain the lost Hit Point unless the item was Broken or Destroyed. As the object holds a tiny sliver of your shadow, you can't recover the lost Hit Point until after the object dissipates." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("342445ef-0cdb-40f0-ac5b-378112569dd9"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("2ba432a6-e634-464d-b587-7c0f5be1514b"), Traits.Instances.Fetchling.ID);
            builder.Add(Guid.Parse("28d6a365-095b-479b-a4f7-235228da574c"), Traits.Instances.Occult.ID);
            builder.Add(Guid.Parse("6b16fbc3-9edb-4656-8e49-6d94a9885bb8"), Traits.Instances.Shadow.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("019474bf-8b55-4612-ad9e-b2b8e42cf06f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
