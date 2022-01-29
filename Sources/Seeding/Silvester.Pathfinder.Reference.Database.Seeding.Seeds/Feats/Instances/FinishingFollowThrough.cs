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
    public class FinishingFollowThrough : Template
    {
        public static readonly Guid ID = Guid.Parse("83f43282-e95f-4630-8fc3-3414996b4819");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Finishing Follow-Through",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6281dc2e-f637-4a90-8a59-7e14faa8bb9a"), Type = TextBlockType.Text, Text = $"Finishing a foe maintains your swagger. You gain panache if your {ToMarkdownLink<Models.Entities.Trait>("finisher", Traits.Instances.Finisher.ID)} brings the target to 0 HP (or brings the highest-level target to 0 HP, if your {ToMarkdownLink<Models.Entities.Trait>("finisher", Traits.Instances.Finisher.ID)} attacks multiple targets)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f23bb9b6-f959-4948-ac54-7c94a03bff9c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
