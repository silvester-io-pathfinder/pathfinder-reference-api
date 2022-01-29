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
    public class SpeakingSky : Template
    {
        public static readonly Guid ID = Guid.Parse("c449ffa8-52c0-4d20-8874-0544e4ec0949");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Speaking Sky",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13b3afca-0841-4cd7-8fc2-36855bd4568e"), Type = TextBlockType.Text, Text = $"You can hear air movement like soft whispers. You gain the {ToMarkdownLink<Models.Entities.Feat>("speaking sky", Feats.Instances.SpeakingSky.ID)} ki spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3c6cfd79-e507-416e-9090-f8f78c95a2f1"), Feats.Instances.JalmeriHeavenseekerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e443a220-96cf-4939-a3cc-d19d5f5614ae"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
