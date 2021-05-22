using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class FlameStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("b8952f75-68a9-4ca2-a257-6022d2f36803");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Flame Strike",
                Level = 5,
                Range = "120 feet.",
                Area = "10-foot radius, 40-foot tall cylinder.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fdbd0f89-b9d6-4141-83dc-bb8769f2fbc6"), Type = TextBlockType.Text, Text = "You call a rain of divine fire that plummets down from above, dealing 8d6 fire damage. Because the flame is infused with divine energy, creatures in the area apply only half their usual fire resistance. Creatures that are immune to fire, instead of gaining the usual benefit of immunity, treat the results of their saving throws as one degree of success better." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1a07d4cf-68c5-4bed-81fa-4d634297d261"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d48acdf4-d874-489c-a596-032fbe4c45bb"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3611a6c-5cd0-4083-825a-90feff7a4eec"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 338
            };
        }
    }
}
