using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Consumables.Instances
{
    public class FeatherToken : Template
    {
        public static readonly Guid ID = Guid.Parse("4450447d-3c84-4271-9cf9-8deaa7ef5d9c");

        protected override Consumable GetConsumable()
        {
            return new Consumable
            {
                Id = ID,
                Name = "Feather Token",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d048f952-b7e2-4cd8-ac21-b5db528a05fe"), "Each feather token appears to be a simple feather from some exotic bird. The feather's shaft, dipped in gold, bears a single arcane rune. Activating a feather token causes it to transform into another object, which then can be used as normal for that object. Each feather can be activated only once, with most of them permanently becoming the item in their description."); ;
        }

        protected override IEnumerable<ConsumableVariant> GetConsumableVariants()
        {
            yield return new ConsumableVariant
            {
                Id = Guid.Parse("1e97b49a-7d45-41d0-8349-f2089210521f"),
                Name = "Feather Token (Anchor)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 7,
                Price = 5500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("df8e6968-f6c6-4641-9576-99b097b9be8a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("22ca6681-fdf1-4ed2-b218-f60d4c98e07e"), "This feather can be activated only on a boat. When activated, this feather transforms into a massive anchor that causes the boat to immediately stop. After 1 day, the anchor vanishes and the boat can move as normal. The anchor is attached to the boat by a magical chain of force, but the chain can be removed by dispel magic or destroyed (Hardness 30, HP 40).");
                            });
                    })
                    .Build()
            };

            yield return new ConsumableVariant
            {
                Id = Guid.Parse("a0c58052-9ad9-405f-ae36-ba22e35076f0"),
                Name = "Feather Token (Bird)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 3,
                Price = 800,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4de595f2-cfac-4b40-9321-fdb08a617af4"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7d7062fb-7c78-4175-b498-1f548c26f409"), "When activated, this token transforms into a small sparrow that waits on your finger for you to relay a message up to 1 minute in length, along with the name and rough location of a recipient. The recipient must be someone you have met, and the location must be somewhere you have visited. After receiving the message, the bird flies off to deliver it, traveling at 30 miles per hour and then searching for the target in the location you provided. If the bird finds the target, it moves adjacent to them, your words emanate from the bird, and the bird then flies off and vanishes. The bird also vanishes if it fails to find your target after 10 hours of searching the location you specified.");
                            });
                    })
                    .Build()
            };

            yield return new ConsumableVariant
            {
                Id = Guid.Parse("f1e2fb02-3f29-4efe-8553-7e2507d3589b"),
                Name = "Feather Token (Chest)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 3,
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("26768850-b6fa-4233-a27a-30783f4fb63e"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("5c363136-f62d-483b-9f8a-2c3d45b289ad"), "When you use this token, a small wooden chest appears and immediately opens. This chest can hold up to 10 Bulk worth of items. Once the chest is closed, it transforms again - this time into a key - taking all of the stored items with it. You can activate this key by spending an Interact action to turn it in an imaginary lock, which causes it to transform back into a chest with all of the items still inside. Once it has turned into a chest a second time, it forever remains a wooden chest.");
                            });
                    })
                    .Build()
            };

            yield return new ConsumableVariant
            {
                Id = Guid.Parse("0d8cd41d-3c95-4901-8791-ada338a2bbc5"),
                Name = "Feather Token (Fan)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 4,
                Price = 1500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("2fb75391-cc34-4dff-ba24-97cacd548bbd"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("665ced0e-fb05-46e1-a368-743f3efafbcf"), "Activating this feather requires you to fan it in a given direction. If this direction is toward the sail of a vessel, the feather flutters up toward the sail and fans continuously, filling the sail with air and granting the vessel a +10-foot circumstance bonus to its Speed for 8 hours. If fanned in any other direction, it instead produces a single casting of gust of wind (DC 20).");
                            });
                    })
                    .Build()
            };

            yield return new ConsumableVariant
            {
                Id = Guid.Parse("69c7947a-515c-4abb-ba25-4578d7eb3bd2"),
                Name = "Feather Token (Holly Bush)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 2,
                Price = 600,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("84a29183-f2ff-44b6-badf-fac74a6ad040"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("2f026ebf-0283-4ff8-82e8-78b72d4594a7"), "When this feather is activated, it immediately transforms into a living holly bush, filling a single square. This bush can provide standard cover. In addition, the bush has 2d4 bright-red berries. While holly berries are usually poisonous, these berries are infused with beneficial magic. You can pick and eat a berry as an Interact action to recover 1 Hit Point. Once plucked from the bush, a berry becomes non-magical after a few seconds, so it doesn't heal you if you don't eat it within the span of your Interact action.");
                                effect.Text(Guid.Parse("6d8e61dc-c84b-4a93-bbef-831cfbc89b9e"), "If activated on soil, the plant continues to grow and thrive (although it doesn't produce any more healing berries). If activated elsewhere, it withers and dies within 1d4 days.");
                            });
                    })
                    .Build()
            };

            yield return new ConsumableVariant
            {
                Id = Guid.Parse("01527fe1-cbbf-4cb9-b037-030022484ac8"),
                Name = "Feather Token (Ladder)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("2131f50d-4ae0-43c7-9959-d67b74fdaf2c"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("dfb2b47e-6cc8-4349-96cf-349620376467"), "When activated, this feather transforms permanently into a 20 - foot - long wooden ladder.");
                            });
                    })
                    .Build()
            };

            yield return new ConsumableVariant
            {
                Id = Guid.Parse("b2891813-3e3f-46bb-b28e-c5ce268007ce"),
                Name = "Feather Token (Swan Boat)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 8,
                Price = 7600,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("610ae315-4170-45e2-ba07-8e3e541e90f0"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("40418d6d-db1b-4f3a-ba3a-9d1e40b22d62"), "This feather can be activated only when tossed into a large body of water, such as a lake or broad river. It transforms into a swan-shaped boat capable of carrying up to 32 Medium creatures, 8 Large creatures, or 2 Huge creatures. The boat moves on the water at a Speed of 50 feet, and lasts 1 day.");
                            });
                    })
                    .Build()
            };

            yield return new ConsumableVariant
            {
                Id = Guid.Parse("49e007c2-8a1f-4897-96c3-3f196e81b19f"),
                Name = "Feather Token (Tree)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 3800,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b863145b-9290-453d-a951-cee98636cf75"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("4331d111-c32d-4ecd-a808-e5ca46c11f67"), "This token can be activated only on an unoccupied patch of earth or soil. When activated, this token transforms into an oak tree, 60 feet tall with a 5-foot-wide trunk. The tree continues to live and grow if conditions are favorable.");
                            });
                    })
                    .Build()
            };

            yield return new ConsumableVariant
            {
                Id = Guid.Parse("5b00e897-42a3-46ef-86b2-ad14cc5d5789"),
                Name = "Feather Token (Whip)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 9,
                Price = 13000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("19029456-5c55-4ba1-8904-6c1332bdb3e2"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("b81ee03f-f1c6-4469-96af-cad0f2875bff"), "This feather transforms into a +1 striking dancing whip when activated. The whip immediately jumps from your grasp and proceeds to attack your enemies until 1 minute has passed or it fails its flat check for dancing, at which point it vanishes. If the whip's target isn't prone, the whip uses its actions to attempt to Trip that creature instead of making a Strike. The whip's total attack modifier for Striking or Tripping is +18 instead of the normal bonus for a dancing weapon.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4c96c86b-3888-4ac5-943a-cf1b42d9e024"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("2f1fca07-6f33-4b5c-98e9-7a3994b16701"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("01fe26a0-2d11-4297-afbe-f2cc5bf5272e"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42cefff8-873d-4092-8465-3522d5111643"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 570
            };
        }
    }
}
