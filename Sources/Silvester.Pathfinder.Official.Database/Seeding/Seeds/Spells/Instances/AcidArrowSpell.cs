using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AcidArrowSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("9ff794c4-74a1-412e-9d44-06d64f1570b1"),
                Name = "Acid Arrow",
                Targets = "1 creature.",
                Description = "You conjure an arrow of acid that keeps corroding the target after it hits. Make a spell attack against the target. On a hit, you deal 3d8 acid damage plus 1d6 persistent acid damage. On a critical hit, double the initial damage, but not the persistent damage.",
                Level = 2,
                Range = 120,
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("ce2df890-5896-491e-a1f2-18a9808e1682"), Level = 2,  Description = "The initial damage increases by 2d8, and the persistent acid damage increases by 1d6." };
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Primal";
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Acid";
            yield return "Attack";
            yield return "Evocation";
        }
    }
}
