using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DimensionDoorSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Conjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("73180f19-0c26-4f90-b377-8ae1d3df6525"),
                Name = "Dimension Door",
                Description = "Opening a door that bypasses normal space, you instantly transport yourself and any items you’re wearing and holding from your current space to a clear space within range you can see.If this would bring another creature with you—even if you’re carrying it in an extradimensional container—the spell is lost.",
                Level = 4,
                Range = 120
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("4d38efb2-763a-44c6-97d6-f67dccc6e8c2"), Level = 5, Description = "The range increases to 1 mile. You don’t need to be able to see your destination, as long as you have been there in the past and know its relative location and distance from you. You are temporarily immune for 1 hour." };
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
