using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BurningHandsSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";
        public override string SavingThrowStat => "Reflex";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("ea3e3b79-80ab-4ef4-9dc7-6fb38561a935"),
                Name = "Burning Hands",
                Level = 1,
                Area = "15-foot cone."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1158bbf7-f745-4c30-9a1f-d7833f60fda4"), Type = Utilities.Text.TextBlockType.Text, Text = "Gouts of flame rush from your hands. You deal 2d6 fire damage to creatures in the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("0433232e-b381-4a6d-bd3c-404bfdedb535"), 
                Level = 1,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e40d5cb9-53ed-44ed-a996-e81ba3b76103"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
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
            yield return "Evocation";
            yield return "Fire";
        }
    }
}
