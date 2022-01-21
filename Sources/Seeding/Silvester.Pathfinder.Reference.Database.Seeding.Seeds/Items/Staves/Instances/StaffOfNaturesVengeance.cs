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
    public class StaffOfNaturesVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("49477d23-5bfe-4148-8545-a10cc7b690ba");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Natures Vengeance",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("082a3705-031c-46f1-8520-de72ece3332a"), "This stout staff is made from gnarled hawthorn. When used as a weapon, a staff of nature's vengeance permanently has the effects of shillelagh. ");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("5ddbe117-418d-4933-81aa-c00488e0d5af"),
                Name = "Staff of Natures Vengeance",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 90000,
                Level = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c1d90caf-6a0e-4d7d-903c-ebd32859be73"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("c611fc94-39a3-4192-a9c8-fd259d0da837"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("69562ce3-faba-4f50-9f00-4a78b2a50c6f"), SpellId = Spells.Instances.Tanglefoot.ID},
                    new StaveSpell { Id = Guid.Parse("e6f3b9b8-25b4-45c2-8a87-292491d3bce5"), Level = 1, SpellId = Spells.Instances.ShockingGrasp.ID},
                    new StaveSpell { Id = Guid.Parse("6e3fbabb-118f-4b46-a483-996323d7ec36"), Level = 1, SpellId = Spells.Instances.SpiderSting.ID},
                    new StaveSpell { Id = Guid.Parse("c667fbbe-32da-4720-a2f9-373770480ba9"), Level = 2, SpellId = Spells.Instances.FlamingSphere.ID},
                    new StaveSpell { Id = Guid.Parse("7c837503-82c1-4294-ae1d-05607d135704"), Level = 2, SpellId = Spells.Instances.VomitSwarm.ID},
                    new StaveSpell { Id = Guid.Parse("58ac43d0-3a42-4dd5-9e69-2160ac0efde6"), Level = 3, SpellId = Spells.Instances.Earthbind.ID},
                    new StaveSpell { Id = Guid.Parse("4b714f9c-3de2-4270-b78a-dc73eeb2fc70"), Level = 3, SpellId = Spells.Instances.WallOfThorns.ID},
                    new StaveSpell { Id = Guid.Parse("c31b825f-fe79-4a3b-9c55-1d69e4717e9a"), Level = 4, SpellId = Spells.Instances.BestialCurse.ID},
                    new StaveSpell { Id = Guid.Parse("e6200ea9-57fc-459b-a0ee-6ce14970bb3e"), Level = 4, SpellId = Spells.Instances.SpikeStones.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("91f93415-fe6e-45ae-9d3b-a2de2562b9fa"),
                Name = "Staff of Natures Vengeance (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 400000,
                Level = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("26c47664-9f71-43ee-9434-acc9401d0c6a"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("c9f4eb8f-16af-40d6-8b3a-898f0423834e"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("d2773acd-5806-455a-8821-55e9c706376d"), Level = 5, SpellId = Spells.Instances.Cloudkill.ID},
                    new StaveSpell { Id = Guid.Parse("db79dfc9-aaf6-4b51-94d4-1661a941b9c4"), Level = 5, SpellId = Spells.Instances.ControlWater.ID},
                    new StaveSpell { Id = Guid.Parse("6763f51b-6f57-44ca-8aae-90e990171c67"), Level = 6, SpellId = Spells.Instances.PurpleWormSting.ID},
                    new StaveSpell { Id = Guid.Parse("1cdbcf76-bffd-4817-ba6c-42d79d612f9b"), Level = 6, SpellId = Spells.Instances.TanglingCreepers.ID},
                }
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("260f6e57-e742-4d10-a4d8-027c693cb92f"),
                Name = "Staff of Natures Vengeance (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 2400000,
                Level = 18,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bf4e5531-8d70-4f74-b1e8-fcaa7ab5cd7c"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("24fe21e6-a703-4858-bcc9-6e7c060c0e24"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("29fd19ca-ecd4-40c3-beb4-e0e82f7df049"), Level = 7, SpellId = Spells.Instances.Sunburst.ID},
                    new StaveSpell { Id = Guid.Parse("9bf008d0-01a5-4b76-8e44-3f86234fc361"), Level = 7, SpellId = Spells.Instances.VolcanicEruption.ID},
                    new StaveSpell { Id = Guid.Parse("11b8c9f9-f8ea-49f5-8b7e-55fe5d53209b"), Level = 8, SpellId = Spells.Instances.Earthquake.ID},
                    new StaveSpell { Id = Guid.Parse("2274e627-1c86-48be-ba1e-b6062e7fdccb"), Level = 8, SpellId = Spells.Instances.PunishingWinds.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ad28b0f1-5333-4bc7-9f2e-13d1867db8c9"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("f515746c-3e3e-4847-a2ab-af1848896c16"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("3dab55ed-21a3-46a8-823f-237985289055"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e538fd1-142a-46e7-b230-5fb7d3097110"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 263
            };
        }
    }
}
