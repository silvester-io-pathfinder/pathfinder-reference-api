using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImplausiblePurchase : Template
    {
        public static readonly Guid ID = Guid.Parse("6df56500-2986-4e86-87c4-e721c6ab3c83");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Implausible Purchase",
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
            yield return new TextBlock { Id = Guid.Parse("06c88b12-f64e-4a33-980f-c170f859c013"), Type = TextBlockType.Text, Text = "Even when impossible, you always have exactly what you need. You can use (feat: Prescient Planner) even if you have already used it after purchasing goods, and you can (action: Interact) to draw the item as a single action instead of a 2-action activity. In addition, five times per day, you can use (feat: Prescient Planner) to pull out a common consumable item up to 6 levels lower than your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("592f8e98-3ad0-402a-9741-3662cd7ba325"), Feats.Instances.PredictivePurchase.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4220a352-8016-47e4-afb7-db468d4f07b1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
