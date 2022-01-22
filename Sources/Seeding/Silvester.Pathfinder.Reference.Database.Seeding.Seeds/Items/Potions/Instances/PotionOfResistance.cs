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
    public class PotionOfResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("d67c2c54-5935-49a0-b14e-2a5d692b5b10");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Potion of Resistance",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c86b95d4-20d7-43bc-92ca-8ae4aa4ddaab"), "Drinking this thick, fortifying potion grants resistance against a single damage type for 1 hour. Each potion of resistance is created to defend against acid, cold, electricity, fire, or sonic damage.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("be7947fe-350d-4d01-8ce8-a9bbdc8bb821"),
                Name = "Potion of Acid Resistance (Lesser)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 4500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f7f40c2b-1961-4e04-a46f-8d716dd1c5a1"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("a1bf15dc-bc31-4d6d-9d1f-03860abfe8f7"), "You gain resistance 5 to Acid damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("d6c268a1-a93f-408b-8069-80e64364fa1e"),
                Name = "Potion of Cold Resistance (Lesser)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 4500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e231778f-7ce6-4859-9e9a-6e2c53e569ae"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("5d914389-146f-401d-aa58-21ea3252a147"), "You gain resistance 5 to Cold damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("983b8c1e-8ff6-4352-b5f7-ce30d47702fc"),
                Name = "Potion of Electricit Resistance (Lesser)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 4500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fcc3e7e1-a5eb-46ef-a962-f8a0fe82eb48"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("66fae4d4-8ef0-40c6-bcdf-3ab51606df05"), "You gain resistance 5 to Electricity damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("e6c7d2af-74ec-4bb3-a781-0e3bde80eac8"),
                Name = "Potion of Fire Resistance (Lesser)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 4500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d66802ba-48e5-4d72-9b18-9ef765c0140e"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("39991435-8b00-4e84-adb6-6b064932a612"), "You gain resistance 5 to Fire damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("1f8f3681-c04e-4490-af3e-42d291d92e98"),
                Name = "Potion of Sonic Resistance (Lesser)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 4500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d6f74799-ce1b-44b0-97b6-237f4ef7d159"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("fdd73ec4-2416-43cf-8ae0-ffb8bb6122c6"), "You gain resistance 5 to Sonic damage.");
                            });
                    })
                    .Build()
            };

            //Moderate
            yield return new PotionVariant
            {
                Id = Guid.Parse("16cca0c9-6ea4-417f-a417-d65d943ccc3a"),
                Name = "Potion of Acid Resistance (Moderate)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                Price = 18000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ba8caaeb-2393-4abb-acf9-83145eb90609"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("86a0134a-ebf0-4dab-b1b1-08cb16bc0c0f"), "You gain resistance 10 to Acid damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("020b699b-b152-4ba2-af6e-891c12dd6bfd"),
                Name = "Potion of Cold Resistance (Moderate)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                Price = 18000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1c5381a9-3188-4430-bbd8-93fd6fe5a159"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("3bc74734-3638-4ee7-831c-bfbf140ce3b4"), "You gain resistance 10 to Cold damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("574d9784-e6c1-4ef9-aa72-1f6bf6ee6f34"),
                Name = "Potion of Electricit Resistance (Moderate)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                Price = 18000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("2ea76b8d-98a8-48f0-8ce1-36aa52bcb8b8"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("541b6efb-3c58-4f88-83b4-51ad3a79cdcf"), "You gain resistance 10 to Electricity damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("46c54549-3b7f-4df2-827b-7abee208cd31"),
                Name = "Potion of Fire Resistance (Moderate)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                Price = 18000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3576e382-0c50-472c-b29d-f2de5643f689"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("4ea3df4b-d393-4c31-9499-8cc10c3ec55e"), "You gain resistance 10 to Fire damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("2ac00a57-03db-4741-9c25-57a2469d0b8f"),
                Name = "Potion of Sonic Resistance (Moderate)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                Price = 18000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e2983ae9-88f7-40c0-b227-4eb0dd6d4ca2"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("07bd321f-3c43-4f6f-bc28-4b4465f5491d"), "You gain resistance 10 to Sonic damage.");
                            });
                    })
                    .Build()
            };

            //Greater
            yield return new PotionVariant
            {
                Id = Guid.Parse("30c7aaf2-80cf-4cd8-9fc5-8aceeeb8af1d"),
                Name = "Potion of Acid Resistance (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 14,
                Price = 85000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3642b4c5-474d-40b1-adc7-8d520d303f5a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7ff98984-86c3-48c5-b02b-6a0bd6007cbc"), "You gain resistance 15 to Acid damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("e140fd9e-bb58-4275-a15a-6409430ec228"),
                Name = "Potion of Cold Resistance (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 14,
                Price = 85000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e55c99f8-aec2-421b-a1b8-47b0bbd5b4c5"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("260cdd0c-6169-4185-b9fc-f86493380fb7"), "You gain resistance 15 to Cold damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("eebea87b-3e91-402f-9f25-ac9ba4df43d4"),
                Name = "Potion of Electricit Resistance (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 14,
                Price = 85000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d14fa1fb-0c4f-48ce-8d03-05071cdd74c1"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("0547c3d7-6791-45bd-a918-10105a98bf93"), "You gain resistance 15 to Electricity damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("dfb6b5ca-dfdd-479b-90e5-ef0c8300c162"),
                Name = "Potion of Fire Resistance (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 14,
                Price = 85000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a161f37a-477f-4b15-9c65-ff3a546827cf"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7fc4db05-cb04-4c68-a059-04df5ac49b87"), "You gain resistance 15 to Fire damage.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("b1860365-c81c-49d5-a238-2bbdf51c33be"),
                Name = "Potion of Sonic Resistance (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 14,
                Price = 85000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6d882381-f860-408f-848f-2b59ed928cff"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("61f1adce-05e6-43b3-94ab-725b31b9b5e2"), "You gain resistance 15 to Sonic damage.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1da4d480-72a8-4ec8-b191-2aad95c0aeea"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("c86af182-1f48-43aa-acd1-90ab5b600159"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("9e811e07-3242-4a4d-9d91-facc1b665d15"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("bb321cc5-c2d6-4845-bc8f-b8a6e202d6f5"), Traits.Instances.Potion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a51ccd36-20f4-40e6-808a-8468678e9b73"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 563
            };
        }
    }
}
