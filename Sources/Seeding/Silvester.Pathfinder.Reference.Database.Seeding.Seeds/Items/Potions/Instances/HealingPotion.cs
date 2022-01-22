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
    public class HealingPotion : Template
    {
        public static readonly Guid ID = Guid.Parse("9ad301af-6cea-4cb8-8046-cadc64d6f0b8");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Healing Potion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0c0c9bd2-3498-4e7d-b993-cca6ec7d6f17"), "A healing potion is a vial of a ruby-red liquid that imparts a tingling sensation as the drinker�s wounds heal rapidly.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("16aa4e6e-2686-4db1-bf0d-f2dfe9b68416"),
                Name = "Healing Potion (Minor)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 1,
                Price = 400,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1ce98263-144f-4169-8263-7ec54fa6c596"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect => 
                            {
                                effect.Text(Guid.Parse("b0afb785-a037-42e2-82c8-563c441eded3"), "The potion restores 1d8 Hit Points.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("8546cefe-4118-4d7b-95a9-5e9061b96a28"),
                Name = "Healing Potion (Lesser)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 3,
                Price = 1200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("62622c34-e285-435f-989a-ab59cab6c207"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("48b3defc-151c-4b00-8ef1-87b884f9ca53"), "The potion restores 2d8+5 Hit Points.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("202c4655-1c8a-43ae-a307-f1c5612ca4ff"),
                Name = "Healing Potion (Moderate)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 5000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("0d8a19de-2a6a-405d-891b-33cdb5d85f18"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("e6e09b37-2f70-41cf-a35e-dea2875af28e"), "The potion restores 3d8+10 Hit Points.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("b0b647e1-eb9b-4034-bc58-65ccd0d3ba2b"),
                Name = "Healing Potion (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 12,
                Price = 40000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5853c5ed-491e-40d4-b811-5f2b42004ef9"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("8e4d36be-9224-4908-a17e-f0e0295f3485"), "The potion restores 6d8+20 Hit Points.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("bf3e5702-c598-48f2-9757-962ea297cc21"),
                Name = "Healing Potion (Major)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 18,
                Price = 500000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("75d82ca2-6e18-4388-9a13-cb7df0d40401"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("ab500411-9467-41da-8fe7-31ed8fbb3c5d"), "The potion restores 8d8+30 Hit Points.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3293bfaf-ac8a-44ce-a081-a0ee774b896d"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("0acf4555-87e4-489c-ac78-ee86a9a21830"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("46841c6e-945b-434e-862a-a1e385210c03"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("8cca708d-e4bf-4ffd-b15d-13b77b07a1c6"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("cdfc6e8d-e907-4cef-857c-1401045fd27f"), Traits.Instances.Positive.ID);
            builder.Add(Guid.Parse("e6b06d3b-443c-4ea0-ae88-b089923f5c7b"), Traits.Instances.Potion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a1d9de05-a22f-4a24-810b-861511c36dd9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 563
            };
        }
    }
}
