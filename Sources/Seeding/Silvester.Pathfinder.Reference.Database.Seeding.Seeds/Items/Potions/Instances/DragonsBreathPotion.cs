using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Potions.Instances
{
    public class DragonsBreathPotion : Template
    {
        public static readonly Guid ID = Guid.Parse("f84487e2-1c92-447e-bb6e-c88947fcf6c7");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Dragon's Breath Potion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e9011cec-91b2-4d77-9c5f-510f3c7c1dc5"), "This viscous liquid contains blood from a certain type of dragon. For 1 hour after you imbibe the concoction, you can unleash a breath weapon used by that type of dragon. The potency of the breath depends on the potion's type, based on the age of the dragon whose blood was used to make the potion. This potion has the trait matching the damage type of the breath weapon.");
            builder.Text(Guid.Parse("3991a6c4-0b08-498c-974e-9cc195070b73"), "Exhaling dragon breath uses a single action. The damage type and the area of the dragon breath depend on the type of dragon blood in the potion, as shown in the table below. After you use the breath weapon, you can't do so again for 1d4 rounds.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("dc35857e-5357-487b-8ed2-aae3a5fcca0a"),
                Name = "Dragon's Breath Potion (Young)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 7,
                Price = 7000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("26900f63-1f40-4429-9fb7-0e516195f5a4"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Details(effect => 
                            {
                                effect.Text(Guid.Parse("13577512-a4f4-404a-8128-cd5d6d7e45b7"), "Regardless of the dragon type, the breath weapon deals 4d6 damage, and each creature in the area must attempt a DC 23 basic save of a type determined by the type of the dragon.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("5e72e5fe-1d0d-4cb8-9eb6-b1bd8d3e87ba"),
                Name = "Dragon's Breath Potion (Adult)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 12,
                Price = 40000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("ff347a73-dac7-425c-8bea-f61ceb6e9a81"), "The damage is 6d6 and the save is DC 29.")
                   .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                   .Add(Guid.Parse("8382000a-3a02-49fd-974f-f47cbf65c3e3"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                   {
                       action
                           .Kind("Interact")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("f47e08e5-d870-4dfc-bd53-8eac0dede1b9"), "Regardless of the dragon type, the breath weapon deals 6d6 damage, and each creature in the area must attempt a DC 29 basic save of a type determined by the type of the dragon.");
                           });
                   })
                   .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("d27e7680-e585-48c0-a5eb-afe50461510c"),
                Name = "Dragon's Breath Potion (Wyrm)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 17,
                Price = 300000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("9725c110-c924-422b-a63a-be3c74cbbf08"), "The damage is 10d6 and the save DC is 37.")
                   .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                   .Add(Guid.Parse("6a39071f-7f49-4d87-8104-94abae6e7761"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                   {
                       action
                           .Kind("Interact")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("24b982a3-0e56-41ea-9925-d4bbffdc0d19"), "Regardless of the dragon type, the breath weapon deals 10d6 damage, and each creature in the area must attempt a DC 37 basic save of a type determined by the type of the dragon.");
                           });
                   })
                   .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("96d68ed1-7370-4e8c-a749-92deb7c94814"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("8221125b-45bd-4218-ae4f-fc83652cd4c5"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("4c036de6-de9f-4ec0-95e4-56bbbf566ef0"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("0aa37648-8321-43db-a16d-cae5d9529a34"), Traits.Instances.Potion.ID);
        }

        protected override Table GetTable()
        {
            return new TableBuilder(Guid.Parse("edfc11a3-bcf1-4261-bfb9-c4ffddf15718"))
                .AddColumn("db82f546-bbe6-4e3a-953d-72da113a6906", "Dragon Type")
                .AddColumn("30b7f13c-3dfa-458f-bb0b-afa02282f689", "Breath Weapon")
                .AddColumn("781da264-e78b-4813-a049-1c1d037a9c2d", "Save")
                .AddRow("47d67158-ab05-4c97-b182-84251696b112", row =>
                {
                    row.AddCell("285e8e46-661e-4f5e-832e-3242116ad7c5", "Black or Copper");
                    row.AddCell("43e1bbd3-20bb-43aa-a46e-b549646b0aba", "30-foot line of acid.");
                    row.AddCell("73587fcd-21f0-46ce-b3d7-250bcaeeb11c", "Reflex");
                })
                .AddRow("11ad756a-1570-42c5-a80c-ece1e960bf15", row =>
                {
                    row.AddCell("2003a6cc-8f51-4cbd-afa7-84da7a7b3048", "Blue or Bronze");
                    row.AddCell("ee7661ed-146c-4c65-8c68-53a9dc9dda59", "30-foot line of electricity.");
                    row.AddCell("890326b0-87a7-4f55-bda2-0f2b24c5837f", "Reflex");
                })
                .AddRow("c04e5e94-0679-496f-9172-30304fc8a88f", row =>
                {
                    row.AddCell("2af5a716-692c-43f9-b662-72524c60e013", "Brass");
                    row.AddCell("12b25e86-ef1d-41b8-ab2c-7fcef770ded8", "30-foot line of fire.");
                    row.AddCell("162dc4e5-a325-4adc-af43-4d03b03401e1", "Reflex");
                })
                .AddRow("d3515778-ff80-4b62-a4f8-11ef95e1eab9", row =>
                {
                    row.AddCell("8ca05396-212a-4e15-b914-c16742069d32", "Green");
                    row.AddCell("542097a0-5c61-43b1-aea3-5ad992a2dba9", "15-foot cone of poison.");
                    row.AddCell("35ce70e7-a1fd-4b92-98c9-0b3d6f74cdfe", "Fortitude");
                })
                .AddRow("c3202d2c-9c89-4605-8c2a-948f4ca533a8", row =>
                {
                    row.AddCell("648e2aa0-3af5-4c1b-bd85-f0ef2d783d51", "Gold or Red");
                    row.AddCell("8c2375c2-ea4c-47cc-aeb6-6ba346a5ced3", "15-foot cone of fire.");
                    row.AddCell("7a0f31a3-086b-455e-b7c0-ad593094b2a8", "Reflex");
                })
                .AddRow("c5dced1e-de49-46b9-b09a-1acf3c364e10", row =>
                {
                    row.AddCell("1b60afe1-4a92-4cee-be7e-eaa0e783224e", "Silver of White");
                    row.AddCell("54253fb6-7baf-4c2c-a2f0-59bbd8cf84af", "15-foot cone of cold.");
                    row.AddCell("514225c7-b202-4685-b3f9-0031cb40b81b", "Reflex");
                })
                .Build();
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf6e40e7-9c65-492f-8b92-d889ca8e7579"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 562
            };
        }
    }
}
