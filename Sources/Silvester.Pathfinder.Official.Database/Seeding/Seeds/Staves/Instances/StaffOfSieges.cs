using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfSieges : Template
    {
        public static readonly Guid ID = Guid.Parse("55e574b7-e8dc-4db3-8e07-75a7c8f236a0");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Sieges",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d4835746-ba17-4c3a-ad28-eee3601d92a5"), Type = TextBlockType.Text, Text = "This adamantine staff is fitted with mithral plates resembling battlements on a castle. Lesser cover, cover, and greater cover don't grant any bonus against your spell attacks or to saving throws against your spells that you cast from the staff." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("918fda0b-82ce-4626-933d-e0043019b088"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("7bad1204-090d-49c9-9715-2c67e3f65046"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("7448e462-d5e7-4b14-aecb-ea63b4326cb2"),
                Price = 6500000,
                ItemLevel = 20,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("df8d36f2-2e22-4dc8-b684-5678ee97d3cb"), SpellId = Spells.Instances.Shield.ID},
                    new StaveSpell { Id = Guid.Parse("ac09a20e-a62a-4886-8b27-dd1f2340f8a6"), SpellId = Spells.Instances.TelekineticProjectile.ID},
                    new StaveSpell { Id = Guid.Parse("34aebfb7-e20d-4b31-894e-dba3057af72b"), Level = 1, SpellId = Spells.Instances.GustOfWind.ID},
                    new StaveSpell { Id = Guid.Parse("988b7c53-1add-42d7-a706-7caff38de9df"), Level = 1, SpellId = Spells.Instances.Longstrider.ID},
                    new StaveSpell { Id = Guid.Parse("cf06757a-ab2b-4ca2-98e4-277c8fb6e02c"), Level = 2, SpellId = Spells.Instances.ObscuringMist.ID},
                    new StaveSpell { Id = Guid.Parse("bb3ee59b-5e62-401f-9ea6-76489e2bf4a4"), Level = 2, SpellId = Spells.Instances.Web.ID},
                    new StaveSpell { Id = Guid.Parse("a57b77f2-05be-4393-9a37-4e8933a1379f"), Level = 3, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("858e4ad0-df64-4914-84c9-7083ccc3bacd"), Level = 3, SpellId = Spells.Instances.WallOfWind.ID},
                    new StaveSpell { Id = Guid.Parse("8bf00996-234f-4cc3-b825-743f165a77ec"), Level = 4, SpellId = Spells.Instances.HallucinatoryTerrain.ID},
                    new StaveSpell { Id = Guid.Parse("351fe905-fbdf-44da-b253-861c777e8765"), Level = 4, SpellId = Spells.Instances.SolidFog.ID},
                    new StaveSpell { Id = Guid.Parse("d0c0bbcb-25f4-4fca-ac77-18e697386bbe"), Level = 4, SpellId = Spells.Instances.WallOfFire.ID},
                    new StaveSpell { Id = Guid.Parse("7dd07dec-2091-4802-a56a-6b04c4f91a40"), Level = 5, SpellId = Spells.Instances.Cloudkill.ID},
                    new StaveSpell { Id = Guid.Parse("b12f01ed-cb3c-49e3-8750-bc3008479766"), Level = 5, SpellId = Spells.Instances.WallOfStone.ID},
                    new StaveSpell { Id = Guid.Parse("b4a1af5a-720d-4dbe-bc3b-cb942ed353fb"), Level = 6, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("a296eac3-3501-4720-ab3b-a87bab7f0a40"), Level = 6, SpellId = Spells.Instances.WallOfForce.ID},
                    new StaveSpell { Id = Guid.Parse("8b4fe53c-e7f1-4cee-b484-5d02e7462758"), Level = 7, SpellId = Spells.Instances.MagnificentMansion.ID},
                    new StaveSpell { Id = Guid.Parse("e0fd9c90-88b8-47ad-afb3-732887e06ce2"), Level = 7, SpellId = Spells.Instances.PrismaticSpray.ID},
                    new StaveSpell { Id = Guid.Parse("36dcdf41-4cca-444f-9160-4afe599dd8ff"), Level = 8, SpellId = Spells.Instances.Earthquake.ID},
                    new StaveSpell { Id = Guid.Parse("dc8bb6af-8e6d-40d3-bc08-d8daa941205a"), Level = 8, SpellId = Spells.Instances.ScintillatingPattern.ID},
                    new StaveSpell { Id = Guid.Parse("6f528ea6-0727-4b5c-9eca-8095a4be123d"), Level = 9, SpellId = Spells.Instances.MeteorSwarm.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d556bea-28d8-49ff-85ea-0d357b1b046d"),
                SourceId = Sources.Instances.Pathfinder156.ID,
                Page = 75
            };
        }
    }
}
