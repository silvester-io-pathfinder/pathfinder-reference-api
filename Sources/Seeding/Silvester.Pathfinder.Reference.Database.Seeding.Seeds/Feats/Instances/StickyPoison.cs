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
    public class StickyPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("70d9f43f-e88d-435a-b16b-b6dbd476c3d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sticky Poison",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("825d844f-dab9-4b57-a9ee-8325bcf7953b"), Type = TextBlockType.Text, Text = $"A combination of additional viscosity and careful application keeps your weapons poisoned even when suffering significant wear and tear. If your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a poisoned weapon would expend its poison without your target attempting an initial save (due to resistance or your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} being a critical failure, for example), attempt a DC 5 flat check. On a success, your weapon remains poisoned. If your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a poisoned weapon succeeds, attempt a DC 17 flat check. On a success, your weapon remains poisoned until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c425c96a-8196-4f58-a815-b54756c2dbee"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9f76ccd-49ae-48ce-8d33-f24ec6b52fd7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
