using Silvester.Pathfinder.Official.Database.Models;
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
                Description = "With a word of necromantic power, you seize control of the target. It gains the minion trait. If you or an ally uses any hostile actions against the target, the spell ends.",
                Level = 3,
                Range = 30,
                Duration = "1 day.",
                Targets = "1 mindless undead creature with a level no greater than bind undead's spell level."
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
            yield return "Divine";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Necromancy";
        }
    }
}
