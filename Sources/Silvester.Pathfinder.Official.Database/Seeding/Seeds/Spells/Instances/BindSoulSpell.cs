using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BindSoulSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Necromancy";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("a0dc825d-78c6-4464-a62e-17d7001c258e"),
                Name = "Bind Soul",
                Description = "You wrench the target’s soul away before it can pass on to the afterlife and imprison it in a black sapphire. While the soul is in the gem, the target can’t be returned to life through any means, even powerful magic such as wish. If the gem is destroyed or bind soul is counteracted on the gem, the soul is freed. The gem has AC 16 and Hardness 10. A gem can’t hold more than one soul, and any attempt wastes the spell.",
                Level = 2,
                Range = 30,
                Targets = "1 creature that died within the last minute."
            };
        }

        public override IEnumerable<SpellRequirement> GetRequirements()
        {
            yield return new SpellRequirement { Id = Guid.Parse("5ece9a7b-d3b6-4cd5-bbf9-c5657ec5cd7f"), Text = "Black Sapphire with a gp value of at least the target's level x100." };
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
            yield return "Uncommon";
            yield return "Evil";
            yield return "Necromancy";
        }
    }
}
