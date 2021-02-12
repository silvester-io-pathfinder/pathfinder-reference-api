using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CloudkillSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Illusion";
        public override string SavingThrowStat => "Fortitude";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("1030f973-aee2-4c2f-8cc5-a98aa4594de4"),
                Name = "Cloudkill",
                Description = "You conjure a poisonous fog. This functions as obscuring mist (page 355), except the area moves 10 feet away from you each round. You deal 6d8 poison damage to each breathing creature that starts its turn in the spell’s area. You can Dismiss the spell.",
                Level = 5,
                Range = 120,
                Area = "20-foot burst",
                Duration = "1 minute."
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
            yield return "Arcane";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Death";
            yield return "Necromancy";
            yield return "Poison";
        }
    }
}
