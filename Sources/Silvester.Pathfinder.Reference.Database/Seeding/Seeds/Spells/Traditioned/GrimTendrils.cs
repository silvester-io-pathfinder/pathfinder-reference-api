using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GrimTendrils : Template
    {
        public static readonly Guid ID = Guid.Parse("dee50182-70ca-460e-8610-91cf21943170");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Grim Tendrils",
                Level = 1,
                Area = "30-foot line.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2bf37083-1d28-4bc5-8d78-ee5d7ff7411c"), Type = TextBlockType.Text, Text = "Tendrils of darkness curl out from your fingertips and race through the air. You deal 2d4 negative damage and 1 persistent bleed damage to living creatures in the line. Each living creature in the line must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bd16bfe1-19b4-47b4-8ac5-1a457756cfc4"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e87c787b-fba6-421b-adb9-be62068e8040"), Type = TextBlockType.Text, Text = "The negative damage increases by 2d4, and the persistent bleed damage increases by 1." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f24db306-7a97-4518-9ddf-e10c12d359ad"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half the negative damage and no persistent bleed damage.",
                Failure = "The creature takes full damage.",
                CriticalFailure = "The creature takes double negative damage and double persistent bleed damage."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5dc76de5-1963-4b35-aa69-ef6b21f8f6ff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 342
            };
        }
    }
}
