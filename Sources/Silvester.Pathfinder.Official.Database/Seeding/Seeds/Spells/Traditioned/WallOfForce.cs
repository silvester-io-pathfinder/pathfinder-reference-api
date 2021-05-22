using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfForce : Template
    {
        public static readonly Guid ID = Guid.Parse("6dfdc671-19e5-4077-b7a5-6fa0b61a87f6");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wall of Force",
                Level = 6,
                Range = "30 feet.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6dfdc671-19e5-4077-b7a5-6fa0b61a87f6"), Type = TextBlockType.Text, Text = "You form an invisible wall of pure magical force up to 50 feet long and up to 20 feet high. The wall has no discernible thickness. You must create the wall in an unbroken open space so its edges don’t pass through any creatures or objects, or the spell is lost. The wall has AC 10, Hardness 30, and 60 Hit Points, and it’s immune to critical hits and precision damage. The wall blocks physical effects from passing through it, and because it’s made of force, it blocks incorporeal and ethereal creatures as well. Teleportation effects can pass through the barrier, as can visual effects (since the wall is invisible)." };
            yield return new TextBlock { Id = Guid.Parse("6dfdc671-19e5-4077-b7a5-6fa0b61a87f6"), Type = TextBlockType.Text, Text = "Wall of force is immune to counteracting effects of its level or lower, but the wall is automatically destroyed by a disintegrate spell of any level or by contact with a rod of cancellation or sphere of annihilation." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6dfdc671-19e5-4077-b7a5-6fa0b61a87f6"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6dfdc671-19e5-4077-b7a5-6fa0b61a87f6"), Type = TextBlockType.Text, Text = "The Hit Points of the wall increases by 20." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Force.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6dfdc671-19e5-4077-b7a5-6fa0b61a87f6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 382
            };
        }
    }
}
