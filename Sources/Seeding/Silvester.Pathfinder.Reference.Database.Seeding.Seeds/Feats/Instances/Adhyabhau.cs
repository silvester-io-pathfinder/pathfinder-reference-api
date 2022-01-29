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
    public class Adhyabhau : Template
    {
        public static readonly Guid ID = Guid.Parse("0598f9ef-68ba-4a6e-a6c7-09db546f91c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adhyabhau",
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
            yield return new TextBlock { Id = Guid.Parse("a52db42e-e772-41e6-9412-03fecd4f3e37"), Type = TextBlockType.Text, Text = $"You descend from the rare psychic vampires known as vetalaranas. Your forebear gained sustenance from the mental and emotional energy of living creatures, which manifests in you as powerful resistance to such effects. You gain a +1 circumstance bonus to Will saves against effects with the {ToMarkdownLink<Models.Entities.Trait>("emotion", Traits.Instances.Emotion.ID)} trait, and when you roll a success on a saving throw against such an effect, you get a critical success instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a784f4bc-1be6-43e9-9f9c-cde30a1dce90"), Traits.Instances.Dhampir.ID);
            builder.Add(Guid.Parse("45475d97-1e73-4bc8-bea7-cf2e93d7c588"), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4815aaf-7239-4619-845c-ec34f494fca8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
