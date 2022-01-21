using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class StealShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("da0e4506-bacf-4e0d-9f16-508d69f27450");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Steal Shadow",
                Level = 3,
                Range = "60 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14d04320-bf8d-4ba3-a58f-d6c1eb38b5d9"), Type = TextBlockType.Text, Text = "You steal a creature's shadow, leaving it weakened and vulnerable.The target must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c64b451c-0f4b-4c08-a42f-60c28835678c"),
                Level = "+1",
                Details =
                {
                     new TextBlock { Id = Guid.Parse("b9eb4997-2f88-43c6-a401-2e923b2833fd"), Type = TextBlockType.Text, Text = "The damage when the spell is cast and when it is sustained increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("a44af360-dbd7-4b76-b745-99d0229b8d44"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is enfeebled 1 for 1 round.",
                Failure = "The target takes 3d4 negative damage and is enfeebled 1 for the spell's duration as you tear its shadow away, collecting it in your hand. On subsequent rounds, when you Sustain the Spell, you can throttle the shadow to deal 3d4 negative damage to the target (basic Fortitude save). Until the spell ends, the target doesn't cast a shadow.",
                CriticalFailure = "As failure, but the target is enfeebled 2."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1b81d167-f25f-45c1-a745-0d74c2e0ced8"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("4c22be20-78b6-459b-9e80-caedadf02ff1"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("2834cf27-5b8d-402e-bbbb-a4e754a0b5c8"), Traits.Instances.Shadow.ID);
            builder.Add(Guid.Parse("39dd2b73-583e-40bc-8a92-79cf7c361ab3"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f382cee5-fb63-4a66-a356-f9c443f0d9fd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
