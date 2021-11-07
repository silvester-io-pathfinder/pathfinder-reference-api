using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PredictivePurchase : Template
    {
        public static readonly Guid ID = Guid.Parse("66210ad8-c4ec-4d1b-8311-e9c8077388f2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Predictive Purchase",
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
            yield return new TextBlock { Id = Guid.Parse("a24f2271-7f67-491a-bd28-2909a16c9f47"), Type = TextBlockType.Text, Text = "You somehow manage to have just the thing for the situation. You gain the (feat: Prescient Planner) and (feat: Prescient Consumable) feats. When using (feat: Prescient Planner), you can draw the item from your backpack (or a similar container) as a 2-action activity, instead of taking 1 minute to do so." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84fb39ba-76ed-444d-9e31-b476422fa046"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
