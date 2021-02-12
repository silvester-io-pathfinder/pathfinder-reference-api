using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ClairaudienceSpellSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("484d98ad-91d1-4b2d-86d0-ec997a6f772b"),
                Name = "Clairaudience",
                Description = "You create an invisible floating ear at a location within range (even if it’s outside your line of sight or line of effect). It can’t move, but you can hear through the ear as if using your normal auditory senses.",
                Level = 3,
                Range = 500,
                CastTime = TimeSpan.FromMinutes(1),
                Duration = "10 minutes."
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
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Divination";
            yield return "Scrying";
        }
    }
}
