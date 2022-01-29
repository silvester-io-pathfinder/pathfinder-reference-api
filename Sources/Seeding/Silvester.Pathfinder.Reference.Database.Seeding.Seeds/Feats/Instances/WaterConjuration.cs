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
    public class WaterConjuration : Template
    {
        public static readonly Guid ID = Guid.Parse("d42dd62a-740a-4fc2-a07a-e98c97c5404b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Water Conjuration",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2164154-3ca7-40e3-8b26-ccb2584de055"), Type = TextBlockType.Text, Text = $"You carry the ocean with you wherever you go. You can cast {ToMarkdownLink<Models.Entities.Spell>("create water", Spells.Instances.CreateWater.ID)} as a primal innate spell once per day. Each time you cast {ToMarkdownLink<Models.Entities.Spell>("create water", Spells.Instances.CreateWater.ID)}, you choose if you create fresh water or salt water." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("57888ad9-27b5-4265-b4b7-2c78d69737ad"), Traits.Instances.Azarketi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eab1c5c1-a3d1-42c1-b44b-8b11dd58d188"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
