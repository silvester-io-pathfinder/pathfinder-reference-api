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
    public class QuickShieldBlock : Template
    {
        public static readonly Guid ID = Guid.Parse("3a08e1ee-a1a1-4623-bf93-c41ccd11ad4a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Shield Block",
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
            yield return new TextBlock { Id = Guid.Parse("075d6979-0ec8-4b2e-80b3-4d298aa130d3"), Type = TextBlockType.Text, Text = $"You can bring your shield into place with hardly a thought. At the start of each of your turns, you gain an additional reaction that you can use only to {ToMarkdownLink<Models.Entities.Feat>("Shield Block", Feats.Instances.ShieldBlock.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ccba836f-b4a2-424e-b3c8-6a06b7cd1b94"), Feats.Instances.VikingDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("e8729d2d-4652-4a15-864b-f60c7bd42a54"), Feats.Instances.ShieldBlock.ID);
            builder.HaveSpecificFeat(Guid.Parse("8241eb10-2827-47b3-b511-5517db5fcf62"), Feats.Instances.ReactiveShield.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28f227d1-1b2b-45c9-97dc-c604f5fe8582"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
