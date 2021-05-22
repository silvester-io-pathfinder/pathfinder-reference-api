using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SepulchralMask : Template
    {
        public static readonly Guid ID = Guid.Parse("7d43752d-dbc7-4401-8260-0f3db0d3eb6f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sepulchral Mask",
                Level = 1,
                Area = "5-foot emanation.",
                Targets = "Enemies in the area.",
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f528a113-5021-4e36-8408-41569947e728"), Type = TextBlockType.Text, Text = "You manifest a supernatural funerary mask, granting you a +1 status bonus to Will saving throws against emotion effects for 1 minute. Its somber countenance forces your foes to confront their regrets and sins. Each enemy in the area when you Cast the Spell or that starts its turn in the area takes 1d4 mental damage and must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f37a78b0-509e-4e94-8e8d-a28162af297d"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("547920c3-d1c3-4648-874a-5f521ddba013"), Type = TextBlockType.Text, Text = "Increase the mental damage by 2d4 and the emanation’s radius by 5 feet." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f7a2ba9f-e7ad-4cb2-9bba-2b2b8e60eb71"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and takes a –1 status penalty to Will saves against emotion effects for 1 round.",
                CriticalFailure = "The creature takes double damage and a –1 status penalty to Will saves against emotion effects for 1 minute."
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
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Sorcerer.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72445b17-1f97-4aea-836e-a73009d11ebc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 236
            };
        }
    }
}
