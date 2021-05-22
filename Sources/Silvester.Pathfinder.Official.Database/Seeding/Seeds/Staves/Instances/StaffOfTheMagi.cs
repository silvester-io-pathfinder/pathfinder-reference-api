using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfTheMagi : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Sigils and runes of ancient and powerful magic cover the iron cladding on this long wooden staff. A staff of the magi is a +3 major striking staff, and when wielding it you gain a +1 circumstance bonus to saving throws against spells." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Voluntarily destroying a staff of the magi unleashes a truly devastating wave of arcane energy that surges out, dissipating with distance. When wielding the staff, you can break it using an Interact action. This releases a 30-foot‑burst magical explosion centered on the staff. This deals 2d10 force damage per charge remaining in the staff (DC 40 basic Reflex save), You automatically critically fail your save. The explosion continues to echo beyond the initial blast zone, dealing half as much damage to creatures beyond 30 feet but within a 60-foot burst. A creature reduced to 0 Hit Points by this damage dies instantly; this is a death effect." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse(""),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 9000000,
                ItemLevel = 20,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), SpellId = Spells.Instances.DetectMagic.ID},
                    new StaveSpell { Id = Guid.Parse(""), SpellId = Spells.Instances.Light.ID},
                    new StaveSpell { Id = Guid.Parse(""), SpellId = Spells.Instances.MageHand.ID},
                    new StaveSpell { Id = Guid.Parse(""), SpellId = Spells.Instances.TelekineticProjectile.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 1, SpellId = Spells.Instances.Lock.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.Enlarge.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.Glitterdust.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.Invisibility.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.Knock.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.TelekineticManeuver.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.Web.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.LightningBolt.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.Invisibility.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.Enlarge.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.WallOfFire.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.Web.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 5, SpellId = Spells.Instances.ConeOfCold.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 5, SpellId = Spells.Instances.Passwall.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 5, SpellId = Spells.Instances.TelekineticHaul.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.Disintegrate.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.LightningBolt.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 7, SpellId = Spells.Instances.ConeOfCold.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 7, SpellId = Spells.Instances.Passwall.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 7, SpellId = Spells.Instances.PlaneShift.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 7, SpellId = Spells.Instances.WallOfFire.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 8, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 8, SpellId = Spells.Instances.MageArmor.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 9, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 9, SpellId = Spells.Instances.MeteorSwarm.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 9, SpellId = Spells.Instances.SummonDragon.ID},
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
