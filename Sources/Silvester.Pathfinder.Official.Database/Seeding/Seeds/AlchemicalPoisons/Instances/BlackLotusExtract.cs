using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class BlackLotusExtract : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("fa11da7d-e05b-486b-a6e0-444dee34bae9");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Black Lotus Extract",
                ItemLevel = 19,
                Price = 650000,
                Usage = "Held in 1 hand",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
            };
        }

        protected override StaggeredEffect GetPoisonEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("040e91d5-536e-4836-b63d-3f29b0301c9f"),
                DifficultyCheck = 42,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "1 Minute",
                MaximumDuration = "6 Rounds"
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Contact.ID;
            yield return Traits.Instances.Virulent.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c36e3697-6277-474e-b992-a95f955a857b"), Text = "Black lotus extract causes severe internal bleeding." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("d82f5ea0-0885-4d2f-9073-8715968a98c4"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("876e2ff9-313e-4e44-a314-1170ed53922b"), Damage = "15d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("d7873b5f-2373-4e16-bf65-5b5a67bed2d5"),  ConditionId = Drained.ID, Severity = 1},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("a22c53f3-6440-4ea1-a0ea-bf7bffeacb7e"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("6396fb33-6c06-448d-b103-b03454ec0e59"), Damage = "17d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("fdd9210a-5c37-4805-b2ef-9fb1177d7526"),  ConditionId = Drained.ID, Severity = 1},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("16bef704-1548-4a7a-ad3b-6d307c5cf93e"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("75c1b506-f418-4971-8443-59db5a0ff891"), Damage = "20d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("ac0aef9e-5c9d-4984-b589-63889f8f1553"),  ConditionId = Drained.ID, Severity = 2},
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df4f9201-28e4-4357-8a2d-e976657da5cf"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
