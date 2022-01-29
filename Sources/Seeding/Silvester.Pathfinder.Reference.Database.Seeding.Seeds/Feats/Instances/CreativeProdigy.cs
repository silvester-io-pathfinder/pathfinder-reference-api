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
    public class CreativeProdigy : Template
    {
        public static readonly Guid ID = Guid.Parse("32309ccc-c749-4d0d-84a7-270a3626d896");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Creative Prodigy",
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
            yield return new TextBlock { Id = Guid.Parse("37c515ff-42ec-458b-a70c-b0a84187b4c9"), Type = TextBlockType.Text, Text = $"You have a powerful creative drive, useful for prevarication and performance. You gain the trained proficiency rank in Deception and Performance. If you are already trained in either of these skills, you become trained in a skill of your choice in its place. You also become trained in Art Lore." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("be9a9261-cdb0-43b9-b3fb-45807c0449b1"), Traits.Instances.Ganzi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e821e124-07ee-49fe-89d2-5316eda9b752"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
