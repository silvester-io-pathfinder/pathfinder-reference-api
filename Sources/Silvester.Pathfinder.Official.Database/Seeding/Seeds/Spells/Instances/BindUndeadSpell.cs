using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BindUndeadSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Necromancy";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("b59d7490-542e-4d17-9463-2e384faf2c0f"),
                Name = "Bind Undead",
                Level = 3,
                Range = 30,
                Duration = "1 day.",
                Targets = "1 mindless undead creature with a level no greater than bind undead's spell level."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba4fb28f-c544-4e92-9c3c-540e371b0754"), Type = Utilities.Text.TextBlockType.Text, Text = "With a word of necromantic power, you seize control of the target. It gains the minion trait. If you or an ally uses any hostile actions against the target, the spell ends." };
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
            yield return "Necromancy";
        }
    }
}
