using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CreateWaterSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Conjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("c5bd7524-e3f5-46b6-b1de-527896978d1c"),
                Name = "Create Water",
                Description = "As you cup your hands, water begins to flow forth from them. You create 2 gallons of water. If no one drinks it, it evaporates after 1 day.",
                Level = 1,
                Range = 0
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
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Conjuration";
            yield return "Water";
        }
    }
}
