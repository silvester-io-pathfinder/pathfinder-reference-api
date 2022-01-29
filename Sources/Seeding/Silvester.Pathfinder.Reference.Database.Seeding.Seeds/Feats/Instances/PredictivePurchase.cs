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
    public class PredictivePurchase : Template
    {
        public static readonly Guid ID = Guid.Parse("741306cc-53c4-4c7d-91df-bb8e347a18a8");

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
            yield return new TextBlock { Id = Guid.Parse("5cda9b11-7e87-4462-8930-d531bf05afa4"), Type = TextBlockType.Text, Text = $"You somehow manage to have just the thing for the situation. You gain the {ToMarkdownLink<Models.Entities.Feat>("Prescient Planner", Feats.Instances.PrescientPlanner.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Prescient Consumable", Feats.Instances.PrescientConsumable.ID)} feats. When using {ToMarkdownLink<Models.Entities.Feat>("Prescient Planner", Feats.Instances.PrescientPlanner.ID)}, you can draw the item from your backpack (or a similar container) as a 2-action activity, instead of taking 1 minute to do so." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16160e0e-f8dd-46e9-9319-f174637fdab9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
