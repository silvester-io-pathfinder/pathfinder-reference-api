using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CollectiveTranspositionSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Conjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("f3fa6c93-ee1d-4da1-982d-55c015c0eeaa"),
                Name = "Collective Transposition",
                Description = "You teleport the targets to new positions within the area. The creatures must each be able to fit in their new space, and their positions must be unoccupied, entirely within the area, and in your line of sight. Unwilling creatures can attempt a Will save.",
                Level = 6,
                Area = "30-foot emanation",
                Targets = "Up to 2 creatures."
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            {
                Id = Guid.Parse("1220f4e1-8504-4702-9fcc-5318b162bb12"),
                CriticalSuccess = "The target can teleport if it wants, but it chooses the destination within range.",
                Success = "The target is unaffected.",
                Failure = "You teleport the target and choose its destination."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("8e38a5fc-f74d-4c0a-b653-4bc2c4610d9e"), Level = 1, Description = "The number of targets increases by 1." };
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
            yield return "Conjuration";
            yield return "Teleportation";
        }
    }
}
