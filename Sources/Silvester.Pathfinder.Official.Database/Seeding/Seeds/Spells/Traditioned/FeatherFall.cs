using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class FeatherFall : Template
    {
        public static readonly Guid ID = Guid.Parse("a9f6569c-4d19-498f-8340-51e00af222e0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Feather Fall",
                Level = 1,
                Range = "60-feet",
                Duration = "1 minute.",
                Targets = "1 falling creature.",
                Trigger = "A creature within range is falling.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("942c6ce2-d0fc-4b0a-a879-31565f3316e6"), Type = TextBlockType.Text, Text = "You cause the air itself to arrest a fall. The target’s fall slows to 60 feet per round, and the portion of the fall during the spell’s duration doesn’t count when calculating falling damage. If the target reaches the ground while the spell is in effect, it takes no damage from the fall. The spell ends as soon as the target lands." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d168711f-6126-4b12-8075-51fce551d445"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 337
            };
        }
    }
}
