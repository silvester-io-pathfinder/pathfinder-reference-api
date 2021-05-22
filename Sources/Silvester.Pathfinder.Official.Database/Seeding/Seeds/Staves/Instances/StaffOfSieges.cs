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
        public static readonly Guid ID = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39");

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
            yield return new TextBlock { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Type = TextBlockType.Text, Text = "This adamantine staff is fitted with mithral plates resembling battlements on a castle. Lesser cover, cover, and greater cover don't grant any bonus against your spell attacks or to saving throws against your spells that you cast from the staff." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"),
                Price = 6500000,
                ItemLevel = 20,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), SpellId = Spells.Instances.Shield.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), SpellId = Spells.Instances.TelekineticProjectile.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 1, SpellId = Spells.Instances.GustOfWind.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 1, SpellId = Spells.Instances.Longstrider.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 2, SpellId = Spells.Instances.ObscuringMist.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 2, SpellId = Spells.Instances.Web.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 3, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 3, SpellId = Spells.Instances.WallOfWind.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 4, SpellId = Spells.Instances.HallucinatoryTerrain.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 4, SpellId = Spells.Instances.SolidFog.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 4, SpellId = Spells.Instances.WallOfFire.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 5, SpellId = Spells.Instances.Cloudkill.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 5, SpellId = Spells.Instances.WallOfStone.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 6, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 6, SpellId = Spells.Instances.WallOfForce.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 7, SpellId = Spells.Instances.MagnificentMansion.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 7, SpellId = Spells.Instances.PrismaticSpray.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 8, SpellId = Spells.Instances.Earthquake.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 8, SpellId = Spells.Instances.ScintillatingPattern.ID},
                    new StaveSpell { Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"), Level = 9, SpellId = Spells.Instances.MeteorSwarm.ID},
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
                Id = Guid.Parse("6d242a7b-35f2-4561-8cc3-d9fff6952c39"),
                SourceId = Sources.Instances.Pathfinder156.ID,
                Page = 75
            };
        }
    }
}
