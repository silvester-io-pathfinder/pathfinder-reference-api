using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ForceBolt : Template
    {
        public static readonly Guid ID = Guid.Parse("20ce2bd7-99f8-4247-b9ff-4ff06d534a26");

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
            yield return new TextBlock { Id = Guid.Parse("3b4d92e2-6ca9-472d-94ef-63b3f26df254"), Type = TextBlockType.Text, Text = "You fire an unerring dart of force from your fingertips. It automatically hits and deals 1d4+1 force damage to the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("5bea9937-2ed3-445b-9336-10a2be00e1cd"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("822c54c9-cc3d-450c-9874-3f50732ea133"), Type = TextBlockType.Text, Text = "The damage increases by 1d4+1." }
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
                Id = Guid.Parse("c2d88d80-6241-4aa0-b3b0-ac88a16530af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
