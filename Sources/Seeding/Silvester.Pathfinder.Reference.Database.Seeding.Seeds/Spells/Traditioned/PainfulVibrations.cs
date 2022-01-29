using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PainfulVibrations : Template
    {
        public static readonly Guid ID = Guid.Parse("55330763-81b1-49c4-851f-a02677516004");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Painful Vibrations",
                Level = 4,
                Range = "100 feet.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8fccf8f0-7603-492d-a8c2-b580ce87ea71"), Type = TextBlockType.Text, Text = "You send powerful sound waves through an opponent's body, vibrating its bones and internal organs painfully. The creature takes 8d6 sonic damage and must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2d5ff977-563b-4971-a3ca-21acb9123b76"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("1845e90a-3ed5-4981-b32f-3824d59d41de"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("29e7a93e-4f8a-4839-adc5-3c05b80f90e0"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target takes full damage, is sickened 1, and is deafened for 1 round.",
                CriticalFailure = "The target takes double damage, is sickened 2, and is deafened for 1 minute."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c955f583-32c2-4063-b35b-6b4ad3344f16"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("04dde1a7-80f4-4a33-b421-fee11ef97f82"), Traits.Instances.Sonic.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb5ab2fb-1417-449d-b2d5-1516295abcf5"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 120
            };
        }
    }
}
