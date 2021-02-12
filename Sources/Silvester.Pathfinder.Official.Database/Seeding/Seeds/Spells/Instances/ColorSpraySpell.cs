using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ColorSpraySpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Illusion";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("060ba321-f5b9-4ac8-907c-fec7bb740713"),
                Name = "Color Spray",
                Description = "Swirling colors affect viewers based on their Will saves.",
                Level = 1,
                Area = "15-foot cone."
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            { 
                Id = Guid.Parse("c5391ad6-09cd-42a9-ac94-74f04f4efc97"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is dazzled for 1 round.",
                Failure = "The creature is stunned 1, blinded for 1 round, and dazzled for 1 minute.",
                CriticalFailure = "The creature is stunned for 1 round and blinded for 1 minute."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("548e581b-6bf6-4a27-9622-996ca1e4e8ff"), Level = 1, Description = "The number of targets increases by 1." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Illusion";
            yield return "Incapacitation";
            yield return "Visual";
        }
    }
}
