using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FatalAria : Template
    {
        public static readonly Guid ID = Guid.Parse("d010a61c-f397-450d-b0dc-c3db26a6d4da");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fatal Aria",
                Level = 10,
                Range = "30 feet.",
                Targets = "1 creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("852b6d36-49af-4196-b35a-c7ecf4ac297e"), Type = TextBlockType.Text, Text = "You perform music so perfect that the target may die of joy or sorrow. Once targeted, the creature becomes temporarily immune for 1 minute. The effect of the spell depends on the target’s level and current Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("2d471fa3-c7aa-4b92-aad8-4c191a59a53c"), Type = TextBlockType.Enumeration, Text = "16th or Lower - The target dies instantly." };
            yield return new TextBlock { Id = Guid.Parse("1d289340-b0ab-4eb8-96c4-1534d35ae050"), Type = TextBlockType.Enumeration, Text = "17th - If the target has 50 Hit Points or fewer, it dies instantly; otherwise, it drops to 0 Hit Points and becomes dying 1." };
            yield return new TextBlock { Id = Guid.Parse("49fd8951-0944-4a79-86c0-8fb822bb2b4c"), Type = TextBlockType.Enumeration, Text = "18th or Higher - The target takes 50 damage. If this brings it to 0 Hit Points, it dies instantly." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Composition.ID;
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba1d0518-6864-443a-a133-03ee89510bb0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
