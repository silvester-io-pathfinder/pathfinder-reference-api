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
    public class DemonMask : Template
    {
        public static readonly Guid ID = Guid.Parse("7130725c-0b68-419e-89cd-8060d678eaa8");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Demon Mask",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0ddedf1a-f5bf-44b2-aed5-3f01a8835510"), "This terrifying mask is crafted in the visage of a leering demon and grants a + 1 item bonus to Intimidation checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b1392ecf-3089-4aa7-8675-2dfbed301463"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("29c42c25-9e1f-4208-9bc3-d481844b8c6a"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("ba070590-dfaa-436a-a033-4bf4b0c819e3"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("16552ae1-b272-457d-8a29-b5e1654e6fac"),
                Name = "Demon Mask",
                Usage = "Worn mask.",
                Level = 4,
                Price = 8500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()

                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("25c3d710-952c-43cd-a7dc-045b3ef04082"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("349569a6-952d-40cf-9b80-6f2a7eff36ee"), "The mask casts a Fear spell with a DC of 20.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("0bea45e5-0ff0-4616-9d8f-4e54d2114377"),
                Name = "Demon Mask (Greater)",
                Usage = "Worn mask.",
                Level = 10,
                Price = 90000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("dade8c97-d9fb-49b9-8805-63204cae9aac"), "The mask grants a +2 item bonus. It casts 3rd-level fear with a DC of 29.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("627c7db5-eeac-44b0-9787-c77b0b89f8c5"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("46ee9e9b-0477-4358-a540-d02086e25871"), "The mask casts a  3rd-level Fear spell with a DC of 29.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("814f8675-41e6-44d3-b8de-b3cdb13ebf84"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 609
            };
        }
    }
}
