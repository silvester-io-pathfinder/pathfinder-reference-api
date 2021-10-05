using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PowerWordKill : Template
    {
        public static readonly Guid ID = Guid.Parse("20800ebc-bea0-420b-b492-0aab5ceb3a9d");

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
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6bc5ff8-b0cc-4f79-9186-cf7e5f759bd1"), Type = TextBlockType.Text, Text = "You utter the most powerful arcane word of power. Once targeted, the target is then temporarily immune for 10 minutes. The effect of the spell depends on the target’s level." };
            yield return new TextBlock { Id = Guid.Parse("b25f8da9-db2d-4305-acf9-3b7f0eb81e84"), Type = TextBlockType.Enumeration, Text = "14th or lower - The target dies instantly." };
            yield return new TextBlock { Id = Guid.Parse("a03b2257-35fd-46f8-b877-092e329dc828"), Type = TextBlockType.Enumeration, Text = "15th - If the target has 50 Hit Points or fewer, it dies instantly; otherwise, it drops to 0 Hit Points and becomes dying 1, or increases its dying condition by 1 if it’s already dying." };
            yield return new TextBlock { Id = Guid.Parse("94ee3100-fddb-4574-b5bf-a34ba59260c4"), Type = TextBlockType.Enumeration, Text = "16th or higher - The target takes 50 damage; if this brings the target to 0 Hit Points, the target dies instantly." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("89861bba-bbe4-4698-9a35-bb60d40d854d"), 
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d878e653-4e94-42a0-8dcc-404777d46d24"), Type = TextBlockType.Text, Text = "The levels at which each outcome applies increase by 2." }
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
                Id = Guid.Parse("f40bd11f-9d2b-439f-9450-8bb8aa4e1976"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 358
            };
        }
    }
}
