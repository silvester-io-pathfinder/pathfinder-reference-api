using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DiscernLocationSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("31f6e676-dbee-4c8f-9f17-a842afab35e3"),
                Name = "Discern Location",
                Description = "You learn the name of the target’s exact location (including the building, community, and country) and plane of existence.",
                Level = 4,
                CastTime = TimeSpan.FromMinutes(10),
                Targets = "1 creature or object",
                Duration = "1 minute"
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("3f43ac0e-e9bf-431b-adad-1e38650be56e"), Text = "You can target a creature only if you’ve seen it in person, have one of its significant belongings, or have a piece of its body. To target an object, you must have touched it or have a fragment of it. Discern location automatically overcomes protections against detection and divination of lower level than this spell, even if they would normally have a chance to block it." };
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
            yield return "Divine";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Uncommon";
            yield return "Detection";
            yield return "Divination";
        }
    }
}
