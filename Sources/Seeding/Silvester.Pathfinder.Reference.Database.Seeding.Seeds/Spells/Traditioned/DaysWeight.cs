using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DaysWeight : Template
    {
        public static readonly Guid ID = Guid.Parse("60f6fb24-d44f-4271-bf45-fa5af659e58c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Day's Weight",
                Level = 3,
                Range = "120 feet.",
                Duration = "1 minute.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8691fe5-95ea-4f32-a1f7-190c72ee280f"), Type = TextBlockType.Text, Text = "You fast-forward time for a single creature, burdening it with the aches and pain of an entire day and making it temporarily tired and weak. The creature must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fd57823f-59ac-4264-952f-ddd610479add"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("68771d3d-5a37-47ee-b4d1-37d6252e9c23"), Type = TextBlockType.Text, Text = "You can target up to 10 creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("abf419b9-a09f-47a1-9844-aa4c7554a379"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is fatigued and enfeebled 1 for 1 round.",
                Failure = "The target is fatigued and enfeebled 1 for the duration.",
                CriticalFailure = "The target is fatigued and enfeebled 2 for the duration. The fatigued condition doesn't end when the spell's duration does (but can still be removed with a night's rest or by similar means)."
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e44739f9-8818-4ef1-9a13-0b9a33b674c1"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62d3d0b1-21d6-4668-bc0e-4864f1a5ffcf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 98
            };
        }
    }
}
