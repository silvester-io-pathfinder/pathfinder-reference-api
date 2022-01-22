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
    public class PotionOfFlying : Template
    {
        public static readonly Guid ID = Guid.Parse("f7b51b07-b762-4951-8fa2-8c8a7b2044d9");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Potion of Flying",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c8e025f4-34d6-4759-b0b8-891b3c4d4962"), "A potion that gives you a temporary fly speed.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("3514aa93-c1c9-4110-97e8-eec06d1d1444"),
                Name = "Potion of Flying",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 8,
                Price = 10000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8eb997f4-4931-4f70-a5d9-288cef89c58f"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect => 
                            {
                                effect.Text(Guid.Parse("7173c0e2-558b-44d2-914f-37bf8accadce"), "You gain a fly Speed of 40 feet for 1 minute.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("7c8845cc-c65c-4c19-8d0c-234a18322296"),
                Name = "Potion of Flying",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 15,
                Price = 100000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ae5120cb-e928-453d-a82e-b60e587e416f"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7c7c65db-5282-4459-92cb-64a6352b451c"), "You gain a fly Speed of 40 feet for 1 hour.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("88669b2e-ba5a-4ae0-92e0-caffecc916aa"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("dc2226a7-2dff-4d2b-a84a-4ce1be715bcc"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("0bb92427-6b4a-4084-914c-5e4c04427ac6"), Traits.Instances.Potion.ID);
            builder.Add(Guid.Parse("cafabaa4-0e54-43e4-8822-547ad2ec4415"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ee77bba-7f4c-480c-ab48-414d6941b248"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 563
            };
        }
    }
}
