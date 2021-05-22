using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class TouchOfTheMoon : Template
    {
        public static readonly Guid ID = Guid.Parse("4d0adf49-b2bb-45d1-8bce-8fedf205c50d");

        public override Spell GetSpell()
        {
            return new Spell
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
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("498b552c-4d08-4731-8e8b-10ffce0ddb07"), Type = TextBlockType.Text, Text = "When you touch the target, a symbol of the moon appears on its forehead, glowing with soft moonlight. The target glows with dim light in a 20-foot radius. It also gets a benefit based on a phase of the moon, starting with the new moon and changing to the next phase at the end of each of its turns." };
            yield return new TextBlock { Id = Guid.Parse("f78dc9d9-344c-4bad-9342-cafb167511e4"), Type = TextBlockType.Enumeration, Text = "New Moon - The target receives no benefit." };
            yield return new TextBlock { Id = Guid.Parse("b0043cd0-889f-4d13-9b77-61743a6e3b2d"), Type = TextBlockType.Enumeration, Text = "Waxing Moon - The target gains a +1 status bonus to attack rolls and a +4 status bonus to damage rolls." };
            yield return new TextBlock { Id = Guid.Parse("29b0c8bd-0ce7-4bdd-9d2d-c840cb90f291"), Type = TextBlockType.Enumeration, Text = "Full Moon - The target gains a +1 status bonus to attack rolls, AC, and saves, and a +4 status bonus to damage." };
            yield return new TextBlock { Id = Guid.Parse("98de71e2-f3fe-42ef-9ff2-e8b61c13bbe9"), Type = TextBlockType.Enumeration, Text = "Waning Moon - The target gains a +1 status bonus to AC and saving throws. After this phase, return to the new moon." };
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
                Id = Guid.Parse("e45ebd32-31f7-4f7f-beea-de2e9dfe9f95"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 398
            };
        }
    }
}
