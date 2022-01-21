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
    public class CraftersEyepiece : Template
    {
        public static readonly Guid ID = Guid.Parse("3b608b57-f80d-4263-b839-0f130659c82c");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Crafter's Eyepiece",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("51d8cf73-5e17-4795-a385-a2fa2da5e339"), "This rugged metal eyepiece etched with square patterns is designed to be worn over a single eye. Twisting the lens reveals a faint three-dimensional outline of an item you plan to build or repair, with helpful labels on the component parts. While worn, this eyepiece gives you a +1 item bonus to Crafting checks. When you Repair an item, increase the Hit Points restored by 15 per proficiency rank instead of 10.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("aaf36432-8938-4150-aa43-4b1bf937b051"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("360bda72-0e11-4df1-b0b2-c1bfec7afd95"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("5a84b91c-4612-49ac-bf18-3a2a17d48b7f"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("b8a2ef19-13ff-4647-b10f-84b6a8531e65"),
                Name = "Crafter's Eyepiece",
                Usage = "Worn eyepiece.",
                Level = 3,
                Price = 6000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()

                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()

                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("d0a697ec-1e64-4f55-89b5-91962e65c111"),
                Name = "Crafter's Eyepiece (Greater)",
                Usage = "Worn eyepiece.",
                Level = 11,
                Price = 120000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0b6b149d-3c12-48c7-9449-73dc1cd33cc0"), "The eyepiece grants a +2 item bonus and can be activated.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("09495ba7-37d9-4ad0-9001-1a1088af3e39"), ActionTypes.Instances.NoAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("1 minute (Interact)")
                            .Frequency("Once per day.")
                            .Details(effects =>
                            {
                                effects.Text(Guid.Parse("64f6e93a-c4c7-4fb5-8bb4-a11a9c9e84f0"), "You calibrate the eyepiece to have it cast a 5th-level creation spell over the course of 1 minute to construct a temporary item.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da630379-1dfc-4677-9c3e-b319016745d4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 609
            };
        }
    }
}
