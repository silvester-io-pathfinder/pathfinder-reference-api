using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineInspiration : Template
    {
        public static readonly Guid ID = Guid.Parse("69990f1a-b209-4efd-883e-7c93fab9f129");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Divine Inspiration",
                Level = 8,
                Range = "Touch.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38e98f06-3ff1-423c-9e98-429fc3eaf7b4"), Type = TextBlockType.Text, Text = "You infuse a target with spiritual energy, refreshing its magic. If it prepares spells, it recovers one 6th-level or lower spell it previously cast today and can cast that spell again. If it spontaneously casts spells, it recovers one of its 6th-level or lower spell slots. If it has a focus pool, it regains its Focus Points, as if it had Refocused." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9e266fc5-d066-4c69-a3e4-8d9d055f2d3e"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("b4cb6ea1-efcf-4dd3-9046-87defbdd9489"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f4b2537-2278-4d9c-a8a5-00cd652b08d4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 331
            };
        }
    }
}
