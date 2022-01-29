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
    public class AlghollthuBound : Template
    {
        public static readonly Guid ID = Guid.Parse("9c1bf8eb-8396-4663-9c51-d79f1bbd78b0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alghollthu Bound",
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
            yield return new TextBlock { Id = Guid.Parse("eb3a002f-8eb4-4dda-bc0e-168ac815817d"), Type = TextBlockType.Text, Text = $"Although you may not even be aware, the alghollthus your ancestors once served maintain a stranglehold on the deepest, tethered parts of your mind. You receive a +2 circumstance bonus to Will saves against {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)} effects that would make you controlled, and if you roll a success against such an effect, you get a critical success instead. However, you gain none of these benefits against effects originating from alghollthus and instead take a -2 circumstance penalty against {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)} effects from alghollthus." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("281f6a6c-8aa5-47be-af87-df5ada831613"), Traits.Instances.Azarketi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9983c665-ea7c-40c3-85d0-f905b939a147"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
