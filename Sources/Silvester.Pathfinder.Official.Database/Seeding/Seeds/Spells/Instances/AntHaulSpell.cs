using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AntHaulSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Transmutation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("001dcfdb-d978-498b-a101-1d13c57b67f2"),
                Name = "Ant Haul",
                Level = 1,
                Range = 0,
                Duration = "8 hours.",
                Targets = "1 creature."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82850481-04c2-4bbd-9b05-13956acaa0f0"), Type = Utilities.Text.TextBlockType.Text, Text = "You reinforce the target’s musculoskeletal system to bear more weight. The target can carry 3 more Bulk than normal before becoming encumbered and up to a maximum of 6 more Bulk." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Primal"; 
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Transmutation";
        }
    }
}
