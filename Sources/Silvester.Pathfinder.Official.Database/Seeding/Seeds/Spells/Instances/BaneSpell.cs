using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BaneSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Enchantment";
        public override string SavingThrowStat => "Will";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("9d06d9f1-deaf-4fd0-8963-9ca6f5a645fa"),
                Name = "Bane",
                Description = "You fill the minds of your enemies with doubt. Enemies in the area must succeed at a Will save or take a –1 status penalty to attack rolls as long as they are in the area. Once per turn, starting the turn after you cast bane, you can use a single action, which has the concentrate trait, to increase the emanation’s radius by 5 feet and force enemies in the area that weren’t yet affected to attempt another saving throw. Bane can counteract bless.",
                Level = 1,
                Area = "5-foot emanation.",
                Duration = "1 minute."
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Enchantment";
            yield return "Mental";
        }
    }
}
