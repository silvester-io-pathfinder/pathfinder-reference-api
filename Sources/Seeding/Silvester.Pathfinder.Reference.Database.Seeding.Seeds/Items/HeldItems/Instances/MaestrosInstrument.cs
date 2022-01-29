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


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.HeldItems.Instances
{
    public class MaestrosInstrument : Template
    {
        public static readonly Guid ID = Guid.Parse("7e4885f1-dfca-4bb8-b828-3b7d8386b37a");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Maestro's Instrument",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("044808da-06aa-4c78-a558-3b85cf52278a"), "A maestro's instrument can be crafted in the form of any variety of handheld musical instrument. A maestro's instrument grants you a +1 item bonus to Performance checks while playing music with the instrument.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("f47a6736-5068-4c58-9d9a-8fd003b13288"),
                Name = "Maestro's Instrument (Lesser)",
                Usage = "Held in 2 hands.",
                CraftingRequirements = "You must supply a casting of Charm.",
                Hands = "2",
                Level = 3,
                Price = 6000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5ecd2faa-c96c-4d58-b7cd-5b6f03bf9244"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("6a1aeaa7-992b-4d85-a6e6-b13cd8f8bd29"), "You play the instrument, causing it to cast a DC 17 Charm spell.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("846532d6-fb78-40bc-84e3-16cae201426e"),
                Name = "Maestro's Instrument (Moderate)",
                Usage = "Held in 2 hands.",
                CraftingRequirements = "You must supply a casting of Charm at 4th level.",
                Hands = "2",
                Level = 10,
                Price = 90000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("05025523-373d-4ddc-8f0b-ff821687a7ab"), "The item bonus is +2, and the charm spell is 4th level (DC 27).")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("21a4e320-7759-443f-8f88-a9cbe3e1d103"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("6cfd3a34-7e51-4b2c-a572-1e40df77a39c"), "You play the instrument, causing it to cast a 4th level DC 27 Charm spell.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("fcbab92a-26ec-4c0c-a080-06a814fba500"),
                Name = "Maestro's Instrument (Greater)",
                Usage = "Held in 2 hands.",
                CraftingRequirements = "You must supply a casting of Charm at 8th level.",
                Hands = "2",
                Level = 18,
                Price = 1900000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d49eb8e6-1872-4874-9fef-4b442b161027"), "The item bonus is +3, and the charm spell is 8th level (DC 38).")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1f068aab-ae4f-4730-8fae-b136e759a818"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("82b5cb1b-b6e1-4d5c-90d5-5b958dce8b68"), "You play the instrument, causing it to cast a 8th level DC 38 Charm spell.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("66163208-e55f-4edc-bfc0-e09dcfdbdf8f"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("1b94b08d-ae2b-450a-bec7-de3188718791"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("871187b5-ead1-44e5-92d1-9f6b4e4e94d4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 574
            };
        }
    }
}
