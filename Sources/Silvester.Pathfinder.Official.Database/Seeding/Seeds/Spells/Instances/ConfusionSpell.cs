using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ConfusionSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Enchantment";
        public override string SavingThrowStat => "Will";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2"),
                Name = "Confusion",
                Level = 4,
                Range = 30,
                Targets = "1 creature.",
                Duration = "1 minute."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d9ca856-2b8d-40b2-acd8-de53e723931d"), Type = Utilities.Text.TextBlockType.Text, Text = "You befuddle your target with strange impulses, causing it to act randomly. The effects are determined by the target’s Will save. You can Dismiss the spell." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("c52f431c-b8b3-4c0b-946d-1491a8e5168f"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target babbles incoherently and is stunned 1.",
                Failure = "The target is confused for 1 minute. It can attempt a new save at the end of each of its turns to end the confusion.",
                CriticalFailure = "The target is confused for 1 minute, with no save to end early."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("283ef60d-8ca4-463d-80cc-12bafa287dfc"),
                Level = 8, 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6af0fd96-e785-48b6-928d-9836e6e0025c"), Type = Utilities.Text.TextBlockType.Text, Text = "You can target up to 10 creatures." }
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
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Emotion";
            yield return "Enchantment";
            yield return "Mental";
        }
    }
}
