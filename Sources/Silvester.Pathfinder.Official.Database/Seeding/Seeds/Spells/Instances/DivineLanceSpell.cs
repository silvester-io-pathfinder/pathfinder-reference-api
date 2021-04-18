using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineLanceSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Cantrip";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("eb816f67-17d1-439b-badb-2657b57f64e2"),
                Name = "Divine Lance",
                Level = 1,
                Range = 30,
                Targets = "1 creature"
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cf9b3fa4-e400-4e53-8e3b-61fa8da555f4"), Type = Utilities.Text.TextBlockType.Text, Text = "You unleash a beam of divine energy. Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or if your deity is true neutral. Make a ranged spell attack roll against the target’s AC. On a hit, the target takes damage of the chosen alignment type equal to 1d4 + your spellcasting ability modifier (double damage on a critical hit). The spell gains the trait of the alignment you chose." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("94452491-58bd-487f-b187-8525fe6a0160"),
                Level = 1, 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("44d1af8e-b3a2-4726-863e-8669acd62fe3"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increased by 1d4." }
                }
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Attack";
            yield return "Cantrip";
            yield return "Evocation";
        }
    }
}
