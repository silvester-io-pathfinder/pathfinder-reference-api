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
    public class ElucidatingMercy : Template
    {
        public static readonly Guid ID = Guid.Parse("c5a0c7f3-81cc-4094-bb25-38da432920fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elucidating Mercy",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97fbc425-7a7c-49d4-94cd-6fc35ba5afb8"), Type = TextBlockType.Text, Text = $"Your mercy grants clarity to those around you just when they need it most. When you use {ToMarkdownLink<Models.Entities.Feat>("Mercy", Feats.Instances.Mercy.ID)}, you can instead attempt a counteract check to remove the confused or stupefied conditions, using the source of that condition to determine the counteract level and DC. If the condition was caused by an ongoing effect and you don't remove that effect, the condition returns at the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ba326a3b-a10d-48aa-8e17-c4046e4166d9"), Feats.Instances.Mercy.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("3971717e-21a1-402a-95a1-c4c3a2d554cd"), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09d116c1-97b4-4269-bbc5-02f500222dd0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
