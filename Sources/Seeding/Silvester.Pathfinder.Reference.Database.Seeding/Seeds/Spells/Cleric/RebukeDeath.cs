using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RebukeDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("37d8a761-64d0-45fc-8861-ec08368cd27c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Rebuke Death",
                Level = 4,
                Area = "20-foot emanation.",
                Targets = "1 living creature per action spent to cast this spell.",
                DomainId = Domains.Instances.Healing.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("190ae005-1b51-41ba-93a6-054a4e92fd75"), Type = TextBlockType.Text, Text = "You snatch creatures from the jaws of death. You can spend 1 to 3 actions Casting this Spell, and you can target a number of creatures equal to the actions spent. Each target regains 3d6 Hit Points. If the target had the dying condition, coming back from dying due to this healing doesn’t increase its wounded condition." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f9f7efd6-0856-424a-95b8-34e715dd4654"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2b094d3b-fcb3-4d10-9d19-69732defc16d"), Type = TextBlockType.Text, Text = "Increase the healing by 1d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92a77076-6f2a-47c5-8ff1-39f7dd1e425f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 396
            };
        }
    }
}
