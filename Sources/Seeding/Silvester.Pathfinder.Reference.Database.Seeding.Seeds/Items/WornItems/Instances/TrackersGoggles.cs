using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class TrackersGoggles : Template
    {
        public static readonly Guid ID = Guid.Parse("68aa792d-3a5b-45d8-a6e7-15752271f9fa");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Tracker's Goggles",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e239ad8c-0768-43ef-b79b-556923217f4e"), "These lenses of forest-green glass are bound in rough leather stitched with crude twine. While wearing these goggles, you gain a +1 bonus to Survival checks to Sense Direction and Track. If you fail a check to Track, you can try again after 30 minutes rather than an hour.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ff486c25-5255-477d-a03c-547433d8cf1c"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("9877ed0d-2020-4b58-9348-1cee50d1501d"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("b92eb8f1-9fc3-409d-a695-4030a9d51de2"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("b5ada0fe-838f-44cb-95e3-3b0fbb047e2c"),
                Name = "Tracker's Goggles",
                Usage = "Worn eyepiece.",
                Level = 3,
                Price = 6000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("bd36a442-ccf1-4d26-8d73-86a1edc308e7"),
                Name = "Tracker's Goggles (Greater)",
                Usage = "Worn eyepiece.",
                Level = 9,
                Price = 66000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0aadc1f9-2780-42d7-8dab-64f50f6a4338"), "The goggles grant a +2 bonus. If you fail a check to Track, you can try again after 15 minutes rather than an hour.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8598f1da-6ff1-4892-abb1-c1330a21a838"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 616
            };
        }
    }
}
