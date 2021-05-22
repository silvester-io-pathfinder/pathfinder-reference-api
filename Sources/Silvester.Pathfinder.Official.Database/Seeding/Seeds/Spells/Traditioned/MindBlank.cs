using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MindBlank : Template
    {
        public static readonly Guid ID = Guid.Parse("2c81268e-b04c-45d1-b250-bab3819c9542");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mind Blank",
                Level = 8,
                Range = "30 feet.",
                Duration = "Until the next time you make your daily preparations.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2e43dfb-c5e3-4c62-b44d-4ccfb65ecd5d"), Type = TextBlockType.Text, Text = "Powerful wards hide a creature from divination magic. The target gains a +4 status bonus to saves against mental effects. Mind blank attempts to counteract any detection, revelation, and scrying effects as if its spell level were 1 higher than its actual level. On a success, the divination effect functions normally except that it detects nothing about the target and its possessions. For instance, detect magic would still detect other magic in the area, but not any magic on the target." };
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
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3bf78171-9c88-45e1-a6ca-9bf27cacb25a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 351
            };
        }
    }
}
