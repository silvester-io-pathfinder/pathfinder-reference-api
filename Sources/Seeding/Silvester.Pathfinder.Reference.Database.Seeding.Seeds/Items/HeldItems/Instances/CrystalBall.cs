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
    public class CrystalBall : Template
    {
        public static readonly Guid ID = Guid.Parse("8abde7ee-33be-4234-8439-3097150b5c27");

        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID,
                Name = "Crystal Ball",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9537f3bf-cd87-4402-8090-5c542df0032d"), "This polished crystal sphere enhances scrying magic. Any visual information received through a spell with the scrying trait that was cast by the crystal ball appears within the sphere, and any auditory information sounds out from the surface of the sphere. When you cast a scrying spell by any other means while holding the sphere, you can relay any information you receive in the same way, allowing others to see or hear the target.");
            builder.Text(Guid.Parse("cf08def7-5b16-4b33-9886-c073aa928593"), "The base version of a crystal ball is a sphere of clear quartz, but other versions are made of different stones.");
        }

        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("6254f0a5-e94e-4f50-aa61-8fa10f1570c3"),
                Name = "Crystal Ball (Clear Quartz)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 14,
                Price = 380000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e77e8951-48b0-4108-afb3-778fae8bc4d1"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact (1 Minute)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("2b2c424b-7bb1-4c48-902d-730a6dc2d2cb"), "The crystal ball casts clairvoyance to your specifications.");
                            });
                    })
                    .Add(Guid.Parse("71f7cd29-c128-40f0-81c8-059ff247549b"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact (10 Minutes)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("dfa11f85-22de-40be-9bdb-fb0467631cb5"), "The crystal ball casts a DC 33 scrying spell to your specifications.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("f7277b78-1449-458a-8b72-6da9c3e27bfa"),
                Name = "Crystal Ball (Selenite)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 15,
                Price = 700000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("3bbf8f2f-b059-4ffc-9ae3-1420cbccbf2e"), "Scrying is DC 36 and gives you the benefits of see invisibility on the target.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("84f91dbe-a63e-4f28-bb7a-8471272133f0"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact (1 Minute)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("9da3d566-e09b-485c-9829-fb97d7683183"), "The crystal ball casts clairvoyance to your specifications.");
                            });
                    })
                    .Add(Guid.Parse("3855a48e-d791-4b3f-b680-45aaa7f85f37"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact (10 Minutes)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("6fb2abf0-7ff1-47d8-a93d-e7edaa383582"), "The crystal ball casts a DC 36 scrying spell to your specifications, and gives you the benfits of See Invisibility on the target.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("c87d822a-0fe5-4cfb-845e-1e0dea6786c3"),
                Name = "Crystal Ball (Moonstone)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 16,
                Price = 750000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0f131e6b-85f2-4fe7-9ac7-cd6685ef2954"), "Scrying is DC 37 and gives you the benefits of mind reading on the target, using the same save DC.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("871f6ee3-fdb4-4d85-b0a3-0b1f53b2505e"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact (1 Minute)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("c2b0e7ab-d899-414e-91af-0f46077220db"), "The crystal ball casts clairvoyance to your specifications.");
                            });
                    })
                    .Add(Guid.Parse("ba9f47e9-5976-46c9-b351-6021bdb0fb40"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact (10 Minutes)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("43d37f2c-654b-464f-a186-f250e1df37e8"), "The crystal ball casts a DC 37 scrying spell to your specifications, and gves you the benfits of Mind Reading on the target, using the same save DC.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("f7426d05-ed47-4dca-a062-940f40a39dae"),
                Name = "Crystal Ball (Peridot)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 17,
                Price = 1250000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("b2c20d20-d807-4c29-b378-dafc44c98202"), "Scrying is DC 39 and gives you the benefits of telepathy for communicating with the target.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a800697c-67e8-4146-97b3-76535f252c17"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact (1 Minute)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("8ccf9f53-9e60-4df1-bfcb-85c554e1f40f"), "The crystal ball casts clairvoyance to your specifications.");
                            });
                    })
                    .Add(Guid.Parse("029c93b4-402e-41c1-9309-a6e6757847ed"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact (10 Minutes)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("3f24a084-551e-4912-afba-28013a2c4248"), "The crystal ball casts a DC 39 scrying spell to your specifications, and gices you the benfit of Telepathy for cummunicating with the target.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("b4de4d81-47cb-4932-92a3-e2f17c995e39"),
                Name = "Crystal Ball (Obsidian)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 19,
                Price = 3200000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("636bf3d8-dffc-4812-a827-49c230ea766a"), "Scrying is DC 41 and gives you the benefits of true seeing for anything you watch through it.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("702cbcfb-bdcb-4bd7-a1e1-8a9361e040ff"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact (1 Minute)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("8c8c6a89-8a9b-4c3f-9f87-60801c3b109e"), "The crystal ball casts clairvoyance to your specifications.");
                            });
                    })
                    .Add(Guid.Parse("93b6af49-e092-40c2-b12e-aed153229083"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact (10 Minutes)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("3fc5a28d-73ee-48f8-8296-39eeed6fce94"), "The crystal ball casts a DC 41 scrying spell to your specifications, and gives you the benefits of true seeing for anything you watch through it.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2c081cf6-5e5e-4fe6-8ce2-8468fcf63cdc"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("60a2abac-020b-41f9-b4fb-3bf2c3442ed1"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("23c6e038-63ff-4f40-b4d2-db258daf453e"), Traits.Instances.Scrying.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d13c98a-0156-4da2-9653-6464a9db86ed"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 572
            };
        }
    }
}
