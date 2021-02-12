using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DisappearanceSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Illusion";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("614267ca-482a-4435-bcea-127594ea342f"),
                Name = "Disappearance",
                Description = "You shroud a creature from others’ senses. The target becomes undetected, not just to sight but to all senses, allowing the target to count as invisible no matter what precise and imprecise senses an observer might have. It’s still possible for a creature to find the target by Seeking, looking for disturbed dust, hearing gaps in the sound spectrum, or finding some other way to discover the presence of an otherwise-undetectable creature",
                Level = 8,
                Range = 0,
                Targets = "1 creature.",
                Duration = "10 minutes"
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Illusion";
        }
    }
}
