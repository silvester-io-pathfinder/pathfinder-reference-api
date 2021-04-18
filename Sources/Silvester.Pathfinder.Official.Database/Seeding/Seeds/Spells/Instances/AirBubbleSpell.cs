using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AirBubbleSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Reaction";
        public override string MagicSchool => "Conjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("fbb8d7cc-6793-484c-80a8-4fafb137e01e"),
                Name = "Air Bubble",
                Targets = "The triggering creature.",
                Duration = "1 minute.",
                Range = 60,
                Level = 4,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eba305d2-2565-417f-8bf4-41ec967add47"), Type = Utilities.Text.TextBlockType.Text, Text = "A bubble of pure air appears around the target’s head, allowing it to breathe normally.The effect ends as soon as the target returns to an environment where it can breathe normally." };
        }

        public override IEnumerable<SpellTrigger> GetTriggers()
        {
            yield return new SpellTrigger { Id = Guid.Parse("04745169-cdce-4409-8caf-10a348a60d93"), Text = "A creature within range enters an environment where it can't breathe." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Divine";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Air";
            yield return "Conjuration";
        }
    }
}
