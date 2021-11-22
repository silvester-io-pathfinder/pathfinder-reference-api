using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
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
            yield return new TextBlock { Id = Guid.Parse("81383709-5b83-4fbe-83d5-1f09f77605fa"), Type = TextBlockType.Text, Text = "You sift through myriad potential futures, seize upon one potential moment in which the target meets a particularly gruesome and fatal end, and then show it a vision of itsimpending demise. The intense mental vision grows more and more terrifying to the target as the doom grows closer, and it takes 3 rounds to reach its conclusion. The target must attempt a Will saving throw to determine the effects. At the end of the spell�s duration, if the target was affected, the target witnesses its death and takes 6d6 mental damage." };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Prediction.ID;
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
