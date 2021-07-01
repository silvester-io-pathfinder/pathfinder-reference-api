using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
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
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("082a3705-031c-46f1-8520-de72ece3332a"), Type = TextBlockType.Text, Text = "This stout staff is made from gnarled hawthorn. When used as a weapon, a staff of nature's vengeance permanently has the effects of shillelagh. " };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("3d5bb8ea-5071-42ce-ad9e-de1d493d8f9c"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("10192375-7fe6-45b3-8c71-ba115631c971"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("5ddbe117-418d-4933-81aa-c00488e0d5af"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
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

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("91f93415-fe6e-45ae-9d3b-a2de2562b9fa"),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("d2773acd-5806-455a-8821-55e9c706376d"), Level = 5, SpellId = Spells.Instances.Cloudkill.ID},
                    new StaveSpell { Id = Guid.Parse("db79dfc9-aaf6-4b51-94d4-1661a941b9c4"), Level = 5, SpellId = Spells.Instances.ControlWater.ID},
                    new StaveSpell { Id = Guid.Parse("6763f51b-6f57-44ca-8aae-90e990171c67"), Level = 6, SpellId = Spells.Instances.PurpleWormSting.ID},
                    new StaveSpell { Id = Guid.Parse("1cdbcf76-bffd-4817-ba6c-42d79d612f9b"), Level = 6, SpellId = Spells.Instances.TanglingCreepers.ID},
                }
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("260f6e57-e742-4d10-a4d8-027c693cb92f"),
                Price = 2400000,
                ItemLevel = 18,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("29fd19ca-ecd4-40c3-beb4-e0e82f7df049"), Level = 7, SpellId = Spells.Instances.Sunburst.ID},
                    new StaveSpell { Id = Guid.Parse("9bf008d0-01a5-4b76-8e44-3f86234fc361"), Level = 7, SpellId = Spells.Instances.VolcanicEruption.ID},
                    new StaveSpell { Id = Guid.Parse("11b8c9f9-f8ea-49f5-8b7e-55fe5d53209b"), Level = 8, SpellId = Spells.Instances.Earthquake.ID},
                    new StaveSpell { Id = Guid.Parse("2274e627-1c86-48be-ba1e-b6062e7fdccb"), Level = 8, SpellId = Spells.Instances.PunishingWinds.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
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
