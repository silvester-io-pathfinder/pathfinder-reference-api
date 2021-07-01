using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfTheMagi : Template
    {
        public static readonly Guid ID = Guid.Parse("5f046522-54b0-4afb-94f4-5cfc2c914546");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of the Magi",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d516587f-39c5-41b5-a076-da4febaefbf3"), Type = TextBlockType.Text, Text = "Sigils and runes of ancient and powerful magic cover the iron cladding on this long wooden staff. A staff of the magi is a +3 major striking staff, and when wielding it you gain a +1 circumstance bonus to saving throws against spells." };
            yield return new TextBlock { Id = Guid.Parse("0188c989-de29-444b-aeb6-efcc2c4c17b4"), Type = TextBlockType.Text, Text = "Voluntarily destroying a staff of the magi unleashes a truly devastating wave of arcane energy that surges out, dissipating with distance. When wielding the staff, you can break it using an Interact action. This releases a 30-foot‑burst magical explosion centered on the staff. This deals 2d10 force damage per charge remaining in the staff (DC 40 basic Reflex save), You automatically critically fail your save. The explosion continues to echo beyond the initial blast zone, dealing half as much damage to creatures beyond 30 feet but within a 60-foot burst. A creature reduced to 0 Hit Points by this damage dies instantly; this is a death effect." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("de97cc77-6c77-44ff-b110-1bcea84c127e"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("c0bafe58-4b72-4fb0-8b6a-1c3f40666859"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("9c8ba839-5ead-469f-8c89-dd78545c5039"),
                Price = 9000000,
                ItemLevel = 20,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("c59ff2ff-8af4-4755-a903-47755db986db"), SpellId = Spells.Instances.DetectMagic.ID},
                    new StaveSpell { Id = Guid.Parse("d7eefe47-89aa-4057-990f-d64ed92a9231"), SpellId = Spells.Instances.Light.ID},
                    new StaveSpell { Id = Guid.Parse("a78b6e03-b158-4c63-bf35-15396f4cf66d"), SpellId = Spells.Instances.MageHand.ID},
                    new StaveSpell { Id = Guid.Parse("8996a15b-c781-457d-ae59-cf16ffed34bd"), SpellId = Spells.Instances.TelekineticProjectile.ID},
                    new StaveSpell { Id = Guid.Parse("62a851df-2abe-4aca-8f6d-185ebafaf95d"), Level = 1, SpellId = Spells.Instances.Lock.ID},
                    new StaveSpell { Id = Guid.Parse("6acd9fa5-5ed9-4eaf-b323-48c75854fb18"), Level = 2, SpellId = Spells.Instances.Enlarge.ID},
                    new StaveSpell { Id = Guid.Parse("68292720-aeb0-46f2-b597-f024cb6ae1ed"), Level = 2, SpellId = Spells.Instances.Glitterdust.ID},
                    new StaveSpell { Id = Guid.Parse("d92241b7-7fa9-4c4d-9127-dc56632c9ccf"), Level = 2, SpellId = Spells.Instances.Invisibility.ID},
                    new StaveSpell { Id = Guid.Parse("551fddd3-71a0-4fe6-b7c0-23da6b6f9434"), Level = 2, SpellId = Spells.Instances.Knock.ID},
                    new StaveSpell { Id = Guid.Parse("30fae7a2-21a0-4a5d-a05b-72baf12e3c4b"), Level = 2, SpellId = Spells.Instances.TelekineticManeuver.ID},
                    new StaveSpell { Id = Guid.Parse("ed1f916c-b5b8-4bb6-90dd-cac0f997eaf9"), Level = 2, SpellId = Spells.Instances.Web.ID},
                    new StaveSpell { Id = Guid.Parse("619a1155-74d7-40a3-b485-a6c54bfef820"), Level = 3, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse("26f15cca-fd14-4721-9deb-46a69dccd112"), Level = 3, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("596c04dc-e441-4db9-8b51-d5769003c18e"), Level = 3, SpellId = Spells.Instances.LightningBolt.ID},
                    new StaveSpell { Id = Guid.Parse("7b31d40b-c7f5-4d7c-8ec9-41b9bd65dcfb"), Level = 4, SpellId = Spells.Instances.Invisibility.ID},
                    new StaveSpell { Id = Guid.Parse("2a277f9e-cf07-45e6-9efa-6137fedd1633"), Level = 4, SpellId = Spells.Instances.Enlarge.ID},
                    new StaveSpell { Id = Guid.Parse("d77e8abb-91fd-48f8-affa-be565b544497"), Level = 4, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("e171bda1-fdbd-46d4-86f7-2ca49288dff6"), Level = 4, SpellId = Spells.Instances.WallOfFire.ID},
                    new StaveSpell { Id = Guid.Parse("d830320d-5d53-4381-97eb-042864d916dc"), Level = 4, SpellId = Spells.Instances.Web.ID},
                    new StaveSpell { Id = Guid.Parse("e3bbb489-56f2-4864-9052-aa7e2c703ae2"), Level = 5, SpellId = Spells.Instances.ConeOfCold.ID},
                    new StaveSpell { Id = Guid.Parse("48c86ad7-02db-4561-ac3a-8adf14a0f342"), Level = 5, SpellId = Spells.Instances.Passwall.ID},
                    new StaveSpell { Id = Guid.Parse("2a04a35e-ad92-47ea-8761-93245d971038"), Level = 5, SpellId = Spells.Instances.TelekineticHaul.ID},
                    new StaveSpell { Id = Guid.Parse("fffc7d6b-f407-48e9-9420-614932e211b1"), Level = 6, SpellId = Spells.Instances.Disintegrate.ID},
                    new StaveSpell { Id = Guid.Parse("62c03776-75fb-4f88-9b84-2898385d1c82"), Level = 6, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse("eb5e7f6d-cab5-4b9b-b412-b81a7d64ec21"), Level = 6, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("fc014542-3d58-48ef-b81d-437007fa0489"), Level = 6, SpellId = Spells.Instances.LightningBolt.ID},
                    new StaveSpell { Id = Guid.Parse("c5cc3b57-edd8-4d69-985a-d9be9edb7433"), Level = 7, SpellId = Spells.Instances.ConeOfCold.ID},
                    new StaveSpell { Id = Guid.Parse("a2402e9c-e037-409a-ab96-0a6e760443b9"), Level = 7, SpellId = Spells.Instances.Passwall.ID},
                    new StaveSpell { Id = Guid.Parse("f87b7116-af0d-4764-939a-04fce20eb1cd"), Level = 7, SpellId = Spells.Instances.PlaneShift.ID},
                    new StaveSpell { Id = Guid.Parse("d228116b-9a73-4d7e-b8ae-9c89dc287ba7"), Level = 7, SpellId = Spells.Instances.WallOfFire.ID},
                    new StaveSpell { Id = Guid.Parse("5a89ad28-3dd1-4c9b-9818-54c591c6476a"), Level = 8, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("4ccbd03b-13b7-49e7-a38b-c41d597e8180"), Level = 8, SpellId = Spells.Instances.MageArmor.ID},
                    new StaveSpell { Id = Guid.Parse("2270ab97-8adf-4421-b76b-ff5ce422a4d4"), Level = 9, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse("5be611ab-8ed9-41e1-aa31-c48699c517a5"), Level = 9, SpellId = Spells.Instances.MeteorSwarm.ID},
                    new StaveSpell { Id = Guid.Parse("342145a3-b535-49ff-b156-38ed639154cc"), Level = 9, SpellId = Spells.Instances.SummonDragon.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d63a494-4a32-4b0f-a6e0-6262a27f2114"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
