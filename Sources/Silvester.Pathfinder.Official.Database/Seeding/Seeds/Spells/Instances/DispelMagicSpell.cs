using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DispelMagicSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("5d1503f3-0176-4480-93b5-c4b4fef56dd3"),
                Name = "Dispel Magic",
                Level = 2,
                Range = 120,
                Targets = "1 spell effect or unattended magic item."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06d14c23-0dc1-457d-8c49-3fdab5484171"), Type = Utilities.Text.TextBlockType.Text, Text = "You unravel the magic behind a spell or effect. Attempt a counteract check against the target (page 458). If you successfully counteract a magic item, the item becomes a mundane item of its type for 10 minutes. This doesn’t change the item’s non-magical properties. If the target is an artifact or similar item, you automatically fail." };
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
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Abjuration";
        }
    }
}
