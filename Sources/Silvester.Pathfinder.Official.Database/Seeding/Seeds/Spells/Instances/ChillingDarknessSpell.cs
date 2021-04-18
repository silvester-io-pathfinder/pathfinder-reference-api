using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ChillingDarknessSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("fc8ec088-6c8d-4d90-9293-9fc0720a3855"),
                Name = "Chilling Darkness",
                Level = 3,
                Range = 120,
                Targets = "1 creature."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2fa66aff-6516-439b-821c-a0e5aa52c2f5"), Type = Utilities.Text.TextBlockType.Text, Text = "You shoot an utterly cold ray of darkness tinged with unholy energy. Make a ranged spell attack against the target. You deal 5d6 cold damage, plus 5d6 evil damage if the target is a celestial." };
            yield return new TextBlock { Id = Guid.Parse("1ae42c07-60c6-4292-a8b6-b06568f97f97"), Type = Utilities.Text.TextBlockType.Text, Text = "If the ray passes through an area of magical light or targets a creature affected by magical light, chilling darkness attempts to counteract the light. If you need to determine whether the ray passes through an area of light, draw a line between yourself and the spell’s target." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("c067daf9-15b6-4f2a-9bac-303584f7f85d"),
                CriticalSuccess = "The target takes double damage.",
                Success = "The target takes full damage."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("4e928728-b53f-43e2-acbe-7b93732500e9"),
                Level = 1, 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("85866a6b-4934-4b35-b98e-0f99876fe455"), Type = Utilities.Text.TextBlockType.Text, Text = "The cold damage increases by 2d6, and the evil damage against celestials increases by 2d6." }
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
            yield return "Divine";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Attack";
            yield return "Cold";
            yield return "Darkness";
            yield return "Evocation";
            yield return "Evil";
        }
    }
}
