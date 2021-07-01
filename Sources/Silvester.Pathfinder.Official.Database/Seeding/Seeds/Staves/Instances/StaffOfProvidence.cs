using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfProvidence : Template
    {
        public static readonly Guid ID = Guid.Parse("6946135b-4041-47c6-84aa-2af8dfb87282");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Providence",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("00b51ddc-2440-4e29-a4f5-982b1e4c1348"), Type = TextBlockType.Text, Text = "A large, stylized symbol of an eye adorns the top of this wooden staff, representing the watchful eye of the divine powers. The bearer of the staff can guide and protect, seeing bounties and tragedies that could befall them in the future. When wielding this staff, you gain a +1 item bonus on Survival checks to Sense Direction or Subsist, and to Religion checks to Recall Knowledge." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("bdf4316c-c274-4000-a465-f405a5a7304d"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("25c89229-8277-4af1-b998-b4ad29360b0e"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("08302ca5-c2c3-417d-bfb3-5eb34d622ef5"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("7973ab6d-9db6-40b8-8c5e-16ec89b10ddb"), SpellId = Spells.Instances.Guidance.ID},
                    new StaveSpell { Id = Guid.Parse("5534721b-5098-469c-9bba-6cb9b10b2035"), SpellId = Spells.Instances.Light.ID},
                    new StaveSpell { Id = Guid.Parse("619cbd33-e346-44eb-bb9a-1d2753d29e5c"), Level = 1, SpellId = Spells.Instances.Bless.ID},
                    new StaveSpell { Id = Guid.Parse("7875ec7a-e4e3-4ff9-b9b1-6056149ca175"), Level = 1, SpellId = Spells.Instances.CreateWater.ID},
                    new StaveSpell { Id = Guid.Parse("234a7c50-c362-41ff-a021-c989a45b0d67"), Level = 2, SpellId = Spells.Instances.Augury.ID},
                    new StaveSpell { Id = Guid.Parse("202dc26c-82da-481a-bd18-4e752638564f"), Level = 2, SpellId = Spells.Instances.CreateFood.ID},
                    new StaveSpell { Id = Guid.Parse("e16d6f57-d840-442a-8af5-9c01bf50bb13"), Level = 2, SpellId = Spells.Instances.SeeInvisibility.ID},
                    new StaveSpell { Id = Guid.Parse("6f64028a-21a9-42ef-ab41-14f473cc1d12"), Level = 2, SpellId = Spells.Instances.Status.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("b3b93d98-24c2-4df3-a963-02eb9a617f36"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("a1a95ffa-d24c-416c-a6a5-5a66bdf4d1a5"), Level = 3, SpellId = Spells.Instances.SafePassage.ID},
                    new StaveSpell { Id = Guid.Parse("b3091251-5b80-4bcc-8319-a27e9f1217e0"), Level = 3, SpellId = Spells.Instances.WanderersGuide.ID},
                    new StaveSpell { Id = Guid.Parse("6bcf8541-966a-4962-977e-daf2b49da788"), Level = 4, SpellId = Spells.Instances.RemoveCurse.ID},
                    new StaveSpell { Id = Guid.Parse("fef54929-13a1-4466-b6b3-8035bb7c4246"), Level = 4, SpellId = Spells.Instances.SpellImmunity.ID},
                    new StaveSpell { Id = Guid.Parse("541885be-af3d-4c3e-8447-05903395caed"), Level = 4, SpellId = Spells.Instances.Status.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("2012c69c-cade-4a82-bd87-63453fdd4e23"),
                Price = 410000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("23f656aa-9e87-4dfa-b2dc-3401278acb75"), Level = 5, SpellId = Spells.Instances.PryingEye.ID},
                    new StaveSpell { Id = Guid.Parse("2a173fea-68e7-491e-a0d0-12458c600148"), Level = 5, SpellId = Spells.Instances.SeeInvisibility.ID},
                    new StaveSpell { Id = Guid.Parse("fcf18afa-edcc-460f-a139-e45aab076b08"), Level = 5, SpellId = Spells.Instances.SpellImmunity.ID},
                    new StaveSpell { Id = Guid.Parse("0fc6da45-f722-4d02-a729-ac9f3ba3bf4e"), Level = 6, SpellId = Spells.Instances.SpellImmunity.ID},
                    new StaveSpell { Id = Guid.Parse("ec45e092-a68c-409d-8464-c8c9d073d282"), Level = 6, SpellId = Spells.Instances.ScintillatingSafeguard.ID},
                    new StaveSpell { Id = Guid.Parse("23425aab-d0b7-4828-8167-62b9b975a602"), Level = 6, SpellId = Spells.Instances.TrueSeeing.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("400518d2-e0d5-4a66-8f49-3c2b3fd0dffb"),
                Price = 6400000,
                ItemLevel = 20,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.True.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("6061aa64-d63f-498f-a6e3-7da0ad6f4666"), Level = 7, SpellId = Spells.Instances.EnergyAegis.ID},
                    new StaveSpell { Id = Guid.Parse("650d0e36-2a5e-48b8-9336-2b99c8aaef23"), Level = 7, SpellId = Spells.Instances.SpellImmunity.ID},
                    new StaveSpell { Id = Guid.Parse("724ad5f5-02dd-48b2-953c-994ccc751e86"), Level = 8, SpellId = Spells.Instances.DivineInspiration.ID},
                    new StaveSpell { Id = Guid.Parse("0d16e629-1655-4efa-b173-5a82fb6d1e2e"), Level = 8, SpellId = Spells.Instances.SpellImmunity.ID},
                    new StaveSpell { Id = Guid.Parse("08c1ac0e-c4d8-4feb-8fc0-15bb0eabf0b4"), Level = 9, SpellId = Spells.Instances.Foresight.ID},
                    new StaveSpell { Id = Guid.Parse("a83ba55f-2dc4-4675-bb99-bcca979b7d24"), Level = 9, SpellId = Spells.Instances.OverwhelmingPresence.ID},
                    new StaveSpell { Id = Guid.Parse("7fd8f99e-90c1-4e44-ab71-436110480bc5"), Level = 9, SpellId = Spells.Instances.SpellImmunity.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afd45cab-693d-4ca2-8641-b20b5ef70c20"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 264
            };
        }
    }
}
