using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DisintegrateSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";
        public override string SavingThrowStat => "Fortitude";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("8280e542-c9e9-41d9-b152-aff2f054d447"),
                Name = "Disintegrate",
                Description = "You fire a green ray at your target. Make a spell attack. You deal 12d10 damage, and the target must attempt a basic Fortitude save. On a critical hit, treat the save result as one degree worse. A creature reduced to 0 HP is reduced to fine powder; its gear remains.",
                Level = 6,
                Range = 120,
                Targets = "1 creature or unattended object."
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("a36f0b28-ae6d-43ea-8671-40f6db86733c"), Text = "An object you hit is destroyed (no save), regardless of Hardness, unless it’s an artifact or similarly hard to destroy. A single casting can destroy no more than a 10-foot cube of matter. This automatically destroys any force construct, such as a wall of force." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("3ce62722-4290-4b4b-949f-d0698ff70202"), Level = 1, Description = "The damage increases by 2d10." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Attack";
            yield return "Evocation";
        }
    }
}
