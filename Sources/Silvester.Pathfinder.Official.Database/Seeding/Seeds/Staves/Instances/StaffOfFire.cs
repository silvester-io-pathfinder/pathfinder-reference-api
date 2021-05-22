using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfFire : Template
    {
        public static readonly Guid ID = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Fire",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Type = TextBlockType.Text, Text = "This staff resembles a blackened and burned length of ashen wood. It smells faintly of soot and glows as if lit by embers. You can use an Interact action to touch the tip of this staff to a torch, tinder, or a flammable substance to ignite a flame." };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"),
                Price = 6000,
                ItemLevel = 3,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), SpellId = Spells.Instances.ProduceFlame.ID},
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Level = 1, SpellId = Spells.Instances.BurningHands.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"),
                Price = 45000,
                ItemLevel = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Level = 2, SpellId = Spells.Instances.BurningHands.ID},
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Level = 2, SpellId = Spells.Instances.FlamingSphere.ID},
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Level = 3, SpellId = Spells.Instances.FlamingSphere.ID},
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Level = 3, SpellId = Spells.Instances.Fireball.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"),
                Price = 180000,
                ItemLevel = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Level = 4, SpellId = Spells.Instances.FireShield.ID},
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Level = 4, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Level = 4, SpellId = Spells.Instances.WallOfFire.ID},
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Level = 5, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"), Level = 5, SpellId = Spells.Instances.WallOfFire.ID},
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
                Id = Guid.Parse("e40ed03e-9aac-4f64-a287-1d8b35e4f37f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
