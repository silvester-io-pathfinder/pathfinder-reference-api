using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Evocation.ID;
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
