using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9f7a6793-3245-4454-8d41-62b230c41892"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("dcfd7c98-3673-4c46-9cea-0fc872c90b03"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("426950aa-3f25-4c0b-a26c-fe95fb29787b"), Traits.Instances.Force.ID);
            builder.Add(Guid.Parse("28465756-444e-4f00-aed9-e1b4c2a3cc70"), Traits.Instances.Wizard.ID);
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
