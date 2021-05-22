using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AirBubble : Template
    {
        public static readonly Guid ID = Guid.Parse("fbb8d7cc-6793-484c-80a8-4fafb137e01e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Air Bubble",
                Targets = "The triggering creature.",
                Duration = "1 minute.",
                Range = "60 feet.",
                Level = 4,
                Trigger = "A creature within range enters an environment where it can't breathe.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eba305d2-2565-417f-8bf4-41ec967add47"), Type = Utilities.Text.TextBlockType.Text, Text = "A bubble of pure air appears around the target’s head, allowing it to breathe normally.The effect ends as soon as the target returns to an environment where it can breathe normally." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 316
            };
        }
    }
}
