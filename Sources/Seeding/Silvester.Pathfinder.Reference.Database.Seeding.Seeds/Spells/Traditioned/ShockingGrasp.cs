using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShockingGrasp : Template
    {
        public static readonly Guid ID = Guid.Parse("5a176a38-8438-4f5b-be5d-50f41adcfd4e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shocking Grasp",
                Level = 1,
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("edf4a6d4-ebbf-4c42-af6b-5ec20e596f1e"), Type = TextBlockType.Text, Text = "You shroud your hands in a crackling field of lightning. Make a melee spell attack roll. On a hit, the target takes 2d12 electricity damage. If the target is wearing metal armor or is made of metal, you gain a +1 circumstance bonus to your attack roll with shocking grasp, and the target also takes 1d4 persistent electricity damage on a hit. On a critical hit, double the initial damage, but not the persistent damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d60108b6-d15e-4d90-b12a-561fd5102a13"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9e3ff90f-02ec-4a15-a607-b9a9297a9457"), Type = TextBlockType.Text, Text = "The damage increases by 1d12, and the persistent electricity damage increases by 1." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("eaa48d6d-e3c8-485e-9609-3508a4d6fa3d"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("526c5c1a-1682-438c-8c19-a67ebd9c84da"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("45c531d7-425a-4524-bf02-0c90ebd6b77d"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5500b241-87c3-459d-83b6-5200431e3914"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 369
            };
        }
    }
}
