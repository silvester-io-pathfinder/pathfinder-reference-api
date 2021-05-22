using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ForceBolt : Template
    {
        public static readonly Guid ID = Guid.Parse("505b32ab-4c0a-4452-a017-307ab110065d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Force Bolt",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("505b32ab-4c0a-4452-a017-307ab110065d"), Type = TextBlockType.Text, Text = "You fire an unerring dart of force from your fingertips. It automatically hits and deals 1d4+1 force damage to the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("505b32ab-4c0a-4452-a017-307ab110065d"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("505b32ab-4c0a-4452-a017-307ab110065d"), Type = TextBlockType.Text, Text = "The damage increases by 1d4+1." }
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Force.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("505b32ab-4c0a-4452-a017-307ab110065d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
