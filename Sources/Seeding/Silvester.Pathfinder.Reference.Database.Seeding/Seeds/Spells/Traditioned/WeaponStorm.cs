using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WeaponStorm : Template
    {
        public static readonly Guid ID = Guid.Parse("68cc985a-d2bb-4d53-8f2c-afc1911c887f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Weapon Storm",
                Level = 4,
                Area = "30-foot cone or 10-foot emanation.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("50f5918f-2d7e-4c4f-9a62-c1941b6f3ea2"), Type = TextBlockType.Text, Text = "You swing a weapon you're holding, and the weapon magically multiplies into duplicates that swipe at all creatures in either a cone or an emanation. This flurry deals four dice of damage to creatures in the area. This damage has the same type as the weapon and uses the same die size. Determine the die size as if you were attacking with the weapon; for instance, if you were wielding a two-hand weapon in both hands, you'd use its two-hand damage die." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("def92b94-7967-4cb7-9bf0-4804310a0244"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2e807c06-2475-4180-bddb-9551629f8491"), Type = TextBlockType.Text, Text = "Add another damage die." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ee2623a2-56b5-48d9-ba56-64dfc6bb3a73"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target takes full damage.",
                CriticalFailure = "The target takes double damage and is subject to the weapon's critical specialization effect."
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
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a32b83d4-0025-4a4a-90a4-f618602249a1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 384
            };
        }
    }
}
