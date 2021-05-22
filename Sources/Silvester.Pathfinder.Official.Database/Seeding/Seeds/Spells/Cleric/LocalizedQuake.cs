using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class LocalizedQuake : Template
    {
        public static readonly Guid ID = Guid.Parse("192b652f-92d5-4fd6-83b8-9001e2d7ae3e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Localized Quake",
                Level = 4,
                Area = "15-foot emanation or 15-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                DomainId = Domains.Instances.Earth.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("96942c90-ad6d-474f-93bf-faaecaafae58"), Type = TextBlockType.Text, Text = "You shake the earth, toppling nearby creatures. Choose whether the spell’s area is a 15-foot emanation or a 15-foot cone when you cast it. Each creature in the area standing on solid ground may take 4d6 bludgeoning damage and must attempt a Reflex saving throw." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1a8db538-a225-43b8-8a8a-6dd5aa4961d1"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("00d2c847-e14f-48ef-adc5-688933db2f67"), Type = TextBlockType.Text, Text = "Increase the damage by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d6384f91-0c99-4f4a-bd51-f4148c410baf"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and falls prone.",
                CriticalFailure = "The creature takes double damage and falls prone."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c60f8e9-c4c4-458a-9985-6674b28ba5c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 393
            };
        }
    }
}
