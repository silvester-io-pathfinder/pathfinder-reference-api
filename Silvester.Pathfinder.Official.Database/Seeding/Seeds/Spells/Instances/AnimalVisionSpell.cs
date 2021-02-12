using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimalVisionSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("9ebcaed3-689b-4886-939d-a8b0399180c5"),
                Name = "Animal Vision",
                Description = "You tap into the target’s senses, allowing you to see, hear, and otherwise sense whatever it senses for the spell’s duration.If the target wishes to prevent you from doing so, it can attempt a Will save, negating the spell on a success, but most animals don’t bother to do so.While tapping into the target’s senses, you can’t use your own body’s senses, but you can change back and forth from your body’s senses to the target’s senses using a single action, which has the concentrate trait.",
                Level = 3,
                Range = 120,
                CastTime = TimeSpan.FromMinutes(1),
                Duration = "1 hour.",
                Targets = "1 animal."
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Divination";
            yield return "Mental";
        }
    }
}
