using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WailOfTheBanshee : Template
    {
        public static readonly Guid ID = Guid.Parse("26e26a2a-c825-4d3c-91d4-abf053a5a19c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wail of the Banshee",
                Level = 9,
                Area = "40-foot emanation.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7da0299-b2d8-4a99-9fbb-942841ee95d6"), Type = TextBlockType.Text, Text = "Your scream chills the souls of enemies that hear it. Each living enemy in the area takes 8d10 negative damage and must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("4bc5c356-6e60-462d-823c-facc3daf52a2"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes full damage.",
                Failure = "The creature takes full damage and is drained 1d4.",
                CriticalFailure = "The creature takes double damage and is drained 4."
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
            builder.Add(Guid.Parse("1875143e-15d9-4edd-8d2a-16d5e686a5f3"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("66256028-395a-4bd6-b3eb-ceb79bd97d59"), Traits.Instances.Death.ID);
            builder.Add(Guid.Parse("6f3a3b12-310c-446f-ac99-670b360c2834"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("aeb6c801-8128-49de-9442-0e9db02aaeb9"), Traits.Instances.Negative.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08b23df1-4de0-42c0-b6ec-97c7bb4f216d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 382
            };
        }
    }
}
