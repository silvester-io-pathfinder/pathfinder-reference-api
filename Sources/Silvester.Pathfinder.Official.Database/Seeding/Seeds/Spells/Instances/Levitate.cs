using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Levitate : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Levitate",
                Level = 3,
                Range = "Touch.",
                Duration = "5 minutes.",
                Targets = "1 unattended object or willing creature.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You defy gravity and levitate the target 5 feet off the ground. For the duration of the spell, you can move the target up or down 10 feet with a single action, which has the concentrate trait. A creature floating in the air from levitate takes a –2 circumstance penalty to attack rolls. A floating creature can spend an Interact action to stabilize itself and negate this penalty for the remainder of its turn. If the target is adjacent to a fixed object or terrain of suitable stability, it can move across the surface by climbing (if the surface is vertical, like a wall) or crawling (if the surface is horizontal, such as a ceiling). The GM determines which surfaces can be climbed or crawled across." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 348
            };
        }
    }
}
