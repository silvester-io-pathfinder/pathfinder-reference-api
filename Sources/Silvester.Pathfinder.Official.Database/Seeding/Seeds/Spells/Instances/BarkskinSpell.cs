using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BarkskinSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("41fcd185-b9ba-41aa-96cf-1a8bcb65a64d"),
                Name = "Barksin",
                Description = "The target’s skin becomes covered in bark. The target gains resistance 2 to bludgeoning and piercing damage and weakness 3 to fire. After the target takes fire damage, it can Dismiss the spell as a free action triggered by taking the damage; doing so doesn’t reduce the fire damage the target was dealt.",
                Level = 2,
                Range = 0,
                Targets = "1 willing creature.",
                Duration = "10 minutes."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("4a665729-f77d-4c8c-8f00-dd3fe078e3d8"), Level = 2, Description = "The resistances increase by 2, and the weakness increases by 3." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Abjuration";
            yield return "Plant";
        }
    }
}
