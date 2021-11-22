using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Spout : Template
    {
        public static readonly Guid ID = Guid.Parse("8542a6f1-4147-4d7d-968e-634ca7fc2507");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spout",
                Level = 1,
                Range = "30 feet.",
                Area = "A 5-foot cube.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ea83041-a490-4f3e-82e7-778d4c9927cb"), Type = TextBlockType.Text, Text = "Water blasts upward, coming out of the ground, rising from a pool, or even manifesting from thin air. Any creatures in the area take bludgeoning damage equal to 1d4 plus your spellcasting ability modifier, with a basic Reflex saving throw." };
            yield return new TextBlock { Id = Guid.Parse("bf75c301-a6b7-4407-8e9a-2e126f5e59ef"), Type = TextBlockType.Text, Text = "You can change this spell�s area to a 5-foot burst, provided you center the burst in a body of water. This body of water can be as small as a pond or creek, but not as small as a puddle or bathtub." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("eb96f446-7452-4c81-b887-31d5b861e4c2"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("7a08ebab-ff71-4478-b480-94085146fa76"), Type = TextBlockType.Text, Text = "The damage increases by 1d4." }
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
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e90037ad-b273-4b69-8e91-2143559b2677"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 130
            };
        }
    }
}
