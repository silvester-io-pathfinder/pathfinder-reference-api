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
    public class ScapegoatParallelSelf : Template
    {
        public static readonly Guid ID = Guid.Parse("b3b61e0c-f5cf-4ae5-861c-3fe991191a9c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scapegoat Parallel Self",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn starts or your oracular curse would advance.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e7efb88-4cbf-4bcc-aad1-579eb52ba3ea"), Type = TextBlockType.Text, Text = $"Seeing Syndara superimpose creatures with similar metaphysical properties, you've realized a way to manipulate the effects of your oracular curse. You immediately change your curse to its minor, moderate, or major stage, or back to its mild form, exchanging the curse effect with that of a parallel version of yourself in another reality." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4ee4c3cb-56c1-4369-97f2-ed72f7c0b19c"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("bbf75071-efc6-4932-a0fd-4de64fd182ab"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("a57b878f-4f25-4944-b9ab-2d903bcf8a2d"), Traits.Instances.Oracle.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66887299-9da3-4c47-b130-e66b3bb57f22"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
