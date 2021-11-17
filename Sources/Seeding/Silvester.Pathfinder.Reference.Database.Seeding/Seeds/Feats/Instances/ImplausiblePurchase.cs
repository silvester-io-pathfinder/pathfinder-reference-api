using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImplausiblePurchase : Template
    {
        public static readonly Guid ID = Guid.Parse("eb065d73-7bf4-48df-b3f4-9f4903877ef6");

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
            yield return new TextBlock { Id = Guid.Parse("7a2edba7-043a-4d8b-973f-ff39f17f0d77"), Type = TextBlockType.Text, Text = "Even when impossible, you always have exactly what you need. You can use (feat: Prescient Planner) even if you have already used it after purchasing goods, and you can (action: Interact) to draw the item as a single action instead of a 2-action activity. In addition, five times per day, you can use (feat: Prescient Planner) to pull out a common consumable item up to 6 levels lower than your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e130e793-dbf2-4997-81fb-2bb5ec4ab596"), Feats.Instances.PredictivePurchase.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8007ea3e-c984-42f1-9431-a554173eab4c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
