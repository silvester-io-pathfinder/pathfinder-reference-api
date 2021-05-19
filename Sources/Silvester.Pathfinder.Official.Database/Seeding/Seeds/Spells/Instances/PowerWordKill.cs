using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PowerWordKill : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Power Word Kill",
                Level = 9,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You utter the most powerful arcane word of power. Once targeted, the target is then temporarily immune for 10 minutes. The effect of the spell depends on the target’s level." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "14th or lower - The target dies instantly." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "15th - If the target has 50 Hit Points or fewer, it dies instantly; otherwise, it drops to 0 Hit Points and becomes dying 1, or increases its dying condition by 1 if it’s already dying." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "16th or higher - The target takes 50 damage; if this brings the target to 0 Hit Points, the target dies instantly." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The levels at which each outcome applies increase by 2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 358
            };
        }
    }
}
