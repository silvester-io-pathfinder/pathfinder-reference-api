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
    public class GracefulPoise : Template
    {
        public static readonly Guid ID = Guid.Parse("3d47e374-73df-4daa-9472-85f4c7b28867");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Graceful Poise",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("24de9de0-5f80-48c8-b970-dc4aabd6ddc8"), Type = TextBlockType.Text, Text = $"With the right positioning, your off-hand weapon can strike like a scorpion's stinger. While you are in this stance, if you make your second {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} from {ToMarkdownLink<Models.Entities.Feat>("Double Slice", Feats.Instances.DoubleSlice.ID)} with an agile weapon, {ToMarkdownLink<Models.Entities.Feat>("Double Slice", Feats.Instances.DoubleSlice.ID)} counts as one attack when calculating your multiple attack penalty." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9f2bbe50-7fa1-42e6-8699-73b2d0f6017f"), Feats.Instances.DoubleSlice.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae43e031-6650-4d18-bf95-a37ce0551f94"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
