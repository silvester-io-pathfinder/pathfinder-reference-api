using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ComprehendLanguageSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("6505b7e2-7c35-45ed-8fda-ff4bf3dd2822"),
                Name = "Comprehend Language",
                Description = "The target can understand the meaning of a single language it is hearing or reading when you cast the spell. This doesn’t let it understand codes, language couched in metaphor, and the like (subject to GM discretion). If the target can hear multiple languages and knows that, it can choose which language to understand; otherwise, choose one of the languages randomly.",
                Level = 2,
                Range = 30,
                Targets = "1 creature.",
                Duration = "1 hour."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("d523848c-c447-477b-b8f3-48dc196055ef"), Level = 3, Description = "The target can also speak the language." };
            yield return new SpellHeightening { Id = Guid.Parse("34a0a521-0496-4876-8e2e-1b7195af1f4b"), Level = 4, Description = "You can target up to 10 creatures, and targets can also speak the language." };
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
            yield return "Divination";
        }
    }
}
