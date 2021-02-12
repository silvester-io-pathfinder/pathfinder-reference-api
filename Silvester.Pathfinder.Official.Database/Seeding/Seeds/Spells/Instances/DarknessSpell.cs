using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DarknessSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Three Actions";
        public override string MagicSchool => "Evocation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e"),
                Name = "Darkness",
                Description = "You create a shroud of darkness that prevents light from penetrating or emanating within the area. Light does not enter the area and any non-magical light sources, such as a torch or lantern, do not emanate any light while inside the area, even if their light radius would extend beyond the darkness. This also suppresses magical light of your darkness spell’s level or lower. Light can’t pass through, so creatures in the area can’t see outside. From outside, it appears as a globe of pure darkness.",
                Level = 2,
                Range = 120,
                Area = "20-foot burst.",
                Duration = "1 minute."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("9d5aaa18-2a33-4468-b219-bf3429228901"), Level = 4, Description = "Even creatures with darkvision (but not greater darkvision) can barely see through the darkness. They treat targets seen through the darkness as concealed." };
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
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Darkness";
            yield return "Evocation";
        }
    }
}
