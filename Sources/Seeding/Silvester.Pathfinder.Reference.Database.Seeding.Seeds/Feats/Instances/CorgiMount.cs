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
    public class CorgiMount : Template
    {
        public static readonly Guid ID = Guid.Parse("71dd91b3-3362-487c-9874-9595c92bf863");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Corgi Mount",
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
            yield return new TextBlock { Id = Guid.Parse("a06b6a6e-3059-49bf-a16f-80a091973da9"), Type = TextBlockType.Text, Text = $"The smallest of fey have ridden corgis as mounts since time immemorial, leading to a pattern on corgis' backs called a “faerie saddle.” You have formed a magical connection with a corgi that can serve as your mount. Your corgi familiar is Small rather than Tiny, and it's appropriate for use as your mount, unlike most familiars. It has the scent ability, which counts against your limit for familiar and master abilities as normal. Furthermore, it can never gain a familiar ability that grants it any Speeds other than a land Speed. If you're a pixie, you can't ride a corgi due to your Size, but you can take this feat to gain a corgi familiar." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b341141f-271f-4189-bee5-f59535c06399"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
