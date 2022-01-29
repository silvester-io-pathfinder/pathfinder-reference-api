using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UncannyCheeks : Template
    {
        public static readonly Guid ID = Guid.Parse("2b20a8dc-b1d1-4507-9e9a-1725fcb354c9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Uncanny Cheeks",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("783d3ecb-f268-4621-9e02-a9a4960a7a8c"), Type = TextBlockType.Text, Text = $"You squirrel away useful objects and seem to retrieve them at just the right time. You gain the {ToMarkdownLink<Models.Entities.Feat>("Prescient Consumable", Feats.Instances.PrescientConsumable.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Prescient Planner", Feats.Instances.PrescientPlanner.ID)} feats, except that you always withdraw the objects from your cheek pouches. This means the object you retrieve must fit in your cheek pouches; this is generally an item of negligible Bulk unless you also have the {ToMarkdownLink<Models.Entities.Feat>("Cheek Pouches", Feats.Instances.CheekPouches.ID)} feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d41764ab-d68c-49ab-befa-971d84230926"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
