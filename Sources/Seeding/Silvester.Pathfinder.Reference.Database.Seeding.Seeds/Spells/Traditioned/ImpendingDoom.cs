using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ImpendingDoom : Template
    {
        public static readonly Guid ID = Guid.Parse("52f7ed6b-27bb-452b-8f94-95dc63b785bd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Impending Doom",
                Level = 3,
                Range = "30 feet.",
                Duration = "3 rounds.",
                Targets = "1 living creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81383709-5b83-4fbe-83d5-1f09f77605fa"), Type = TextBlockType.Text, Text = "You sift through myriad potential futures, seize upon one potential moment in which the target meets a particularly gruesome and fatal end, and then show it a vision of itsimpending demise. The intense mental vision grows more and more terrifying to the target as the doom grows closer, and it takes 3 rounds to reach its conclusion. The target must attempt a Will saving throw to determine the effects. At the end of the spell's duration, if the target was affected, the target witnesses its death and takes 6d6 mental damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0a74cd3a-074c-4386-b821-5b62f031d05c"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("48c0e745-85ff-4195-8d7f-c729cf284138"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("8e2ea55d-ad8c-4bce-aef4-7fb4e4eb31b3"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is unaffected for 1 round. On the second round, it becomes flat-footed. Finally, on the third round, it becomes frightened 1. At the end of the third round, it takes half damage.",
                Failure = "The creature is immediately flat-footed. On the second round, it becomes frightened 2. Finally, on the third round, it also becomes stunned 1. At the end of the third round, the creature takes full damage.",
                CriticalFailure = "The creature is immediately flat-footed and frightened 3. On the second round, it becomes stunned 1. Finally, on the third round, it also becomes paralyzed. At the end of the third round, the creature takes double damage."
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9232f9bb-e9d9-49b3-bbe2-61f9ceb1b19c"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("837b871c-4422-4403-a615-314ef02ac496"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("74fdb4bd-50a7-4219-b2d1-d88c22a40d3f"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("ae1a3bcd-33f7-4cfd-bcdd-83fa7c1258cf"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("d9565221-2599-4e26-9fc4-93863b0018fc"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("780d5be6-000b-4351-a9b1-ef919efa9f7a"), Traits.Instances.Prediction.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65ff0191-35c2-4b4a-81c1-3c857906582c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 110
            };
        }
    }
}
