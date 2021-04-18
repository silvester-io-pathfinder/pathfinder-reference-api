using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CloakOfColorsSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Illusion";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("2c2d2218-3a46-4075-899c-c4e9353aaec3"),
                Name = "Cloak of Colors",
                Level = 5,
                Range = 30,
                Targets = "1 creature.",
                Duration = "1 minute."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9a5617f3-f18c-407c-98f5-f0092737c1cf"), Type = Utilities.Text.TextBlockType.Text, Text = "A cloak of swirling colors shrouds the target. Creatures are dazzled while adjacent to it, and attacking the target causes a brilliant flash of light. A creature that hits the target with a melee attack must attempt a Will save." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            {
                Id = Guid.Parse("1396db52-7879-4bee-afcb-71cc424a3726"),
                Success = "The attacker is unaffected.",
                Failure = "The attacker is blinded for 1 round.",
                CriticalFailure = "The attacker is stunned for 1 round. The creature is temporarily immune until the end of its turn; this effect has the incapacitation trait."
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Illusion";
            yield return "Visual";
        }
    }
}
