using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Potions.Instances
{
    public class Panacea : Template
    {
        public static readonly Guid ID = Guid.Parse("634244e1-fb3b-485a-8df6-9cf0fba908e4");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Panacea",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9fae2e2a-4b36-4063-a641-789f239c09d4"), "This potion appears to shift colors, and no two observers describe it in the same way. When consumed, it attempts to counteract all curses and diseases affecting you, as well as the blinded and deafened conditions from spells affecting you. The potion has a counteract level of 7 and a +20 modifier for the roll.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("938cf875-2686-466b-b16c-ca5a27753f57"),
                Name = "Panacea",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 13,
                Price = 45000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("22da3ef9-e06a-461f-8659-dd8719cb059f"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("729b45c2-6924-411c-aa71-db1b5a5dd66c"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("ef06fafa-ae34-4a3a-a29d-5642879229c6"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("899c60e6-3702-488f-a1b3-d20504460b3c"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("dee69fda-d40b-49b6-b8c9-0424ce14b029"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("39c32a84-e1b0-4f3a-affe-0f5783397b63"), Traits.Instances.Potion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b92e0475-82e7-4ec3-87a2-26c50d9bf444"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 563
            };
        }
    }
}
