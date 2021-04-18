using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DimensionalLockSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("1e745c5e-5d8f-4abd-b66c-e0e582833257"),
                Name = "Dimensional Lock",
                Level = 7,
                Range = 120,
                Area = "60-foot burst",
                Duration = "1 day."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d3057c9-fcc9-4949-a17e-9aa46a0dcd6f"), Type = Utilities.Text.TextBlockType.Text, Text = "You create a shimmering barrier that attempts to counteract teleportation effects and planar travel into or out of the area, including items that allow access to extradimensional spaces (such as a bag of holding). Dimensional lock tries to counteract any attempt to summon a creature into the area but doesn’t stop the creature from departing when the summoning ends." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Divine";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Uncommon";
            yield return "Abjuration";
        }
    }
}
