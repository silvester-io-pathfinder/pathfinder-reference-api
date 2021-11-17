using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ProtectiveWard : Template
    {
        public static readonly Guid ID = Guid.Parse("12be19ae-8cac-40b8-834e-8ac1a582024b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Protective Ward",
                Level = 1,
                Area = "5-foot-radius emanation centered on you.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d05189a-7002-49b1-bfea-fddf7cd1e7c3"), Type = TextBlockType.Text, Text = "You emanate a shimmering aura of protective magic. You and any allies in the area gain a +1 status bonus to AC. Each time you Sustain the Spell, the emanation’s radius increases by 5 feet, to a maximum of 30 feet." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f445a4d4-1e5b-4cd6-803d-b9f53d4eec49"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
