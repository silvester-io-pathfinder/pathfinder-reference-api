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
    public class AdaptiveVision : Template
    {
        public static readonly Guid ID = Guid.Parse("fea89d0f-3fd7-4fe4-8b6f-290670f0ea38");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adaptive Vision",
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
            yield return new TextBlock { Id = Guid.Parse("437e447c-dc86-4666-b3c0-8e9f17e7e84b"), Type = TextBlockType.Text, Text = $"~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("b25d4cc4-3e4e-4150-89d4-dd6570c12c5b"), Type = TextBlockType.Text, Text = $"After years of using black powder weaponry in dimly lit spaces, you've become accustomed to dazzling flashes of light and sudden shifts in illumination. You gain a +1 circumstance bonus to saving throws against {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} effects. If you roll a success on a saving throw against a {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} effect, you get a critical success instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("191fad62-b32f-447e-bd4d-959657b88c04"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
