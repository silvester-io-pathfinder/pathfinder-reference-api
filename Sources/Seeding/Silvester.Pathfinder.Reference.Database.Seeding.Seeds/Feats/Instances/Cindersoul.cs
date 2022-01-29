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
    public class Cindersoul : Template
    {
        public static readonly Guid ID = Guid.Parse("3e4ea97b-aa6d-4506-8c49-7f62b84c4146");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cindersoul",
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
            yield return new TextBlock { Id = Guid.Parse("0a73e6be-131f-4833-bcf6-98a657ddb8af"), Type = TextBlockType.Text, Text = $"The fire of your elemental ancestor manifests like dying embers of a blaze, and your inner charcoal helps staunch bleeding, purify simple poisons, and absorb acid. The DC for you to recover from persistent acid, bleed, and poison damage is 10 instead of 15 (or 5 if you have particularly effective assistance)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13eafdae-8bcd-483c-aeb8-9929c3ef9004"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
