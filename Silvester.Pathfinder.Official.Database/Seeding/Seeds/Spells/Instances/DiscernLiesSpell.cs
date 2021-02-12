using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DiscernLiesSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("d8cf6802-13fb-4518-a463-538b28bed2da"),
                Name = "Discern Lies",
                Description = "Falsehoods ring in your ears like discordant notes. You gain a +4 status bonus to Perception checks when someone Lies.",
                Level = 4,
                Duration = "10 minutes"
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
            yield return "Uncommon";
            yield return "Divination";
            yield return "Mental";
            yield return "Revelation";
        }
    }
}
