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
    public class EnlargedChassis : Template
    {
        public static readonly Guid ID = Guid.Parse("bafc4e2a-c776-4c7b-8e66-06a3443b7891");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enlarged Chassis",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("62623a04-2016-4069-b96b-0e39ddc1fb0c"), Type = TextBlockType.Text, Text = $"You've empowered your core to support a larger body, granting you size and additional reach. You gain the effects of {ToMarkdownLink<Models.Entities.Spell>("enlarge", Spells.Instances.Enlarge.ID)} constantly." };
            yield return new TextBlock { Id = Guid.Parse("a5212ea4-070b-422e-b07b-1bd423c48e76"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("f3f0dc79-2efa-4635-8e93-6ce79d1ce004"), Type = TextBlockType.Text, Text = $"~ Enhancement: Your core's empowerment has stabilized, allowing for greater support. You are no longer clumsy due to the effects of {ToMarkdownLink<Models.Entities.Spell>("enlarge", Spells.Instances.Enlarge.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("114ea71c-1e06-4f7a-ad5c-141b0b54b7f9"), or => 
            {
                or.HaveSpecificSize(Guid.Parse("dee6360a-9d6c-4278-9c52-df6905ae2e8b"), AncestrySizes.Instances.Medium.ID);
                or.HaveSpecificSize(Guid.Parse("3f703cb2-d489-4c04-a694-efaf323775e6"), AncestrySizes.Instances.Small.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3d1c685-4257-489e-a9f7-823a08658d94"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
