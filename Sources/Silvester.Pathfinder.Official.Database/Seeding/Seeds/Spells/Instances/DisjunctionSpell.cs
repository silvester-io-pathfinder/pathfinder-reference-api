using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DisjunctionSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("05375af9-4bc5-4eab-8731-2fb74c2062d9"),
                Name = "Disjunction",
                Level = 9,
                Range = 120,
                Targets = "1 magical item."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5e2bbdd-edd9-4905-8c2c-1f8f08305001"), Type = Utilities.Text.TextBlockType.Text, Text = "Crackling energy disjoins the target. You attempt to counteract it (page 458). If you succeed, it’s deactivated for 1 week. On a critical success, it’s destroyed. If it’s an artifact or similar item, you automatically fail." };
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
            yield return "Uncommon";
            yield return "Abjuration";
        }
    }
}
