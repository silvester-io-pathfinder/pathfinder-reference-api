using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Staves.Instances
{
    public class StaffOfImpossibleVisions : Template
    {
        public static readonly Guid ID = Guid.Parse("20bc189e-5cf1-4b4d-99b6-062952146eb3");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Impossible Visions",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9044ef68-350f-4c8f-93f9-6a777964e9a3"), "This bizarre staff is made from oak, capped with a cluster of eye-shaped gemstones that seem to move and undulate at the corner of your vision. While wielding the staff, you can peer through the eyes, using your normal visual senses (including any benefits of spells affecting your vision, like see invisibility). You can maneuver the staff to see things around corners, at higher elevations, or in places where the staff can fit but your head can't. This doesn't provide sufficient line of effect to target creatures around corners. The eyes are as vulnerable as your eyes and can be affected by anything that alters your vision, such as a blinding flash of light.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("6b9f76fc-76a2-4d73-98e7-a096a3b6fc64"),
                Name = "Staff of Impossible Visions",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 23000,
                Level = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("2744e164-849f-4349-8577-7675e01b4ed0"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("86ec3b8a-9d7c-4a02-b5bf-eda01e70ae1c"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("720e6fa4-6abd-403f-972e-96d86c307f4d"), SpellId = Spells.Instances.Daze.ID},
                    new StaveSpell { Id = Guid.Parse("004ecb54-b828-4491-ae8d-b312d67376c6"), Level = 1, SpellId = Spells.Instances.Fear.ID},
                    new StaveSpell { Id = Guid.Parse("f7e81cdc-47d2-4b6f-96d8-210c6ea01e10"), Level = 1, SpellId = Spells.Instances.PhantomPain.ID},
                    new StaveSpell { Id = Guid.Parse("14a9bf82-db9e-4e2e-9835-39c03f2fdfd8"), Level = 2, SpellId = Spells.Instances.Augury.ID},
                    new StaveSpell { Id = Guid.Parse("c2d444f5-ccb1-4a0c-bd1d-8612d85c9a88"), Level = 2, SpellId = Spells.Instances.Paranoia.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("2b4a9a49-2f3b-4df6-ac9a-cf63846057aa"),
                Name = "Staff of Impossible Visions (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 180000,
                Level = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c81a7617-9546-4c82-adf6-4dcfe3223f7c"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("5f64ef5b-3527-4c7a-abc4-59b532e00e10"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("7e5cbac3-e0b6-40d3-a68f-fd702a49c5f4"), Level = 3, SpellId = Spells.Instances.HypnoticPattern.ID},
                    new StaveSpell { Id = Guid.Parse("f69a9eb0-7da1-448e-b7b9-23973b7c5c8f"), Level = 3, SpellId = Spells.Instances.Paralyze.ID},
                    new StaveSpell { Id = Guid.Parse("23075db4-a484-42d7-bf7f-586a6813c70b"), Level = 4, SpellId = Spells.Instances.CountlessEyes.ID},
                    new StaveSpell { Id = Guid.Parse("3e6f66f6-f174-4ca8-ac40-09b779678617"), Level = 4, SpellId = Spells.Instances.PhantasmalKiller.ID},
                    new StaveSpell { Id = Guid.Parse("434007cd-2827-45f6-b919-1355330affb3"), Level = 5, SpellId = Spells.Instances.StrangeGeometry.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("271ac229-d2c0-45d3-9ae7-5138f0f7d05b"),
                Name = "Staff of Impossible Visions (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 1000000,
                Level = 16,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f8669385-8249-434d-833d-fc622163854f"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("13f6b86d-b3db-4087-a094-0149062ab13b"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("616a9f9c-afb1-4923-89cb-a323fee370d6"), Level = 6, SpellId = Spells.Instances.BlindingFury.ID},
                    new StaveSpell { Id = Guid.Parse("a4141232-ec80-4050-bdf9-33ccefef23e0"), Level = 6, SpellId = Spells.Instances.PhantasmalCalamity.ID},
                    new StaveSpell { Id = Guid.Parse("6109884a-4452-4567-93aa-a07a6003c357"), Level = 7, SpellId = Spells.Instances.VisionsOfDanger.ID},
                    new StaveSpell { Id = Guid.Parse("e8fbfd15-205f-4a3a-96e9-37dd2cce8ea9"), Level = 7, SpellId = Spells.Instances.WarpMind.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("8d4e4ecb-bea7-45c3-9aa0-720fc5286d80"),
                Name = "Staff of Impossible Visions (True)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 7000000,
                Level = 20,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.True.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b7228671-9c64-43e8-9384-acab515e2dfc"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("9214bdd3-3346-4994-9d50-cf34f23cf669"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("8d96658c-3fa3-4d84-ae2e-88f6d873134f"), Level = 8, SpellId = Spells.Instances.SpiritSong.ID},
                    new StaveSpell { Id = Guid.Parse("1da68819-0e55-4781-8662-48f62ab61fea"), Level = 8, SpellId = Spells.Instances.UncontrollableDance.ID},
                    new StaveSpell { Id = Guid.Parse("8757d5d0-1cd0-4f97-a1f2-5b3060628af6"), Level = 9, SpellId = Spells.Instances.UnfathomableSong.ID},
                    new StaveSpell { Id = Guid.Parse("b9799aa0-dea1-41ff-87ae-06ca50b7295e"), Level = 9, SpellId = Spells.Instances.Weird.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("892995be-c095-4a06-ad7b-3bf2cc172bae"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("da4619bc-58e6-4fe1-b9f9-65a9bc7a4e22"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("5c880890-07a0-4f72-9a49-c5062806d604"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("6d4a1842-3107-4eb5-893e-8d1ff6d43656"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32ce50bd-4ac2-4eb2-95e7-d006640976f5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 263
            };
        }
    }
}
