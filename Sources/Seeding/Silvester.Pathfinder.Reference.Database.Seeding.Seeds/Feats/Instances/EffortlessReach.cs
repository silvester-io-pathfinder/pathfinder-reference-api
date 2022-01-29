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
    public class EffortlessReach : Template
    {
        public static readonly Guid ID = Guid.Parse("572d767f-f628-4c71-bfd5-fdb79d0e499f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Effortless Reach",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("833bca8b-2213-4fcb-979a-ea2d37938bd6"), Type = TextBlockType.Text, Text = $"Focusing the powers of your ki to augment your blows, you stretch and lengthen your body in ways that defy logic. Your unarmed attacks gain the {ToMarkdownLink<Models.Entities.Trait>("reach", Traits.Instances.Reach.ID)} trait." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8d64728-ebb3-4fa1-b8f7-50cb5e8403ef"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
