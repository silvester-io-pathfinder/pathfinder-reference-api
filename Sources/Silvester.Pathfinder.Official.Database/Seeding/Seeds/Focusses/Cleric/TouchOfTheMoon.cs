using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Focusses.Cleric.Instances
{
    public class TouchOfTheMoon : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Focus GetFocus()
        {
            return new Focus
            {
                Id = ID,
                Name = "Touch of the Moon",
                Level = 4,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                DomainId = Domains.Instances.Moon.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                FocusTypeId = FocusTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you touch the target, a symbol of the moon appears on its forehead, glowing with soft moonlight. The target glows with dim light in a 20-foot radius. It also gets a benefit based on a phase of the moon, starting with the new moon and changing to the next phase at the end of each of its turns." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "New Moon - The target receives no benefit." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Waxing Moon - The target gains a +1 status bonus to attack rolls and a +4 status bonus to damage rolls." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Full Moon - The target gains a +1 status bonus to attack rolls, AC, and saves, and a +4 status bonus to damage." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Waning Moon - The target gains a +1 status bonus to AC and saving throws. After this phase, return to the new moon." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Enchantment.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 398
            };
        }
    }
}
