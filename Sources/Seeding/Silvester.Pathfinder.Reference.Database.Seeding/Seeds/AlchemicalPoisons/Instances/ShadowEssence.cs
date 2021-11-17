using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class ShadowEssence : Template
    {
        public static readonly Guid ID = Guid.Parse("eec5e097-c60a-4a1d-91d3-57bcf30e6a31");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Shadow Essence",
                ItemLevel = 10,
                Price = 16000,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
            };
        }

        protected override StaggeredEffect GetPoisonEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("91536163-f5f3-4666-b738-76b88e8feab3"),
                DifficultyCheck = 29,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "Immediate",
                MaximumDuration = "6 Rounds",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Injury.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44e8074e-5cc8-46f9-8829-7ab92e42f176"), Text = "Distilled from the Plane of Shadow, this oily substance imposes tenebrous effects. The enfeebled condition from shadow essence lasts for 24 hours." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("4fb01e13-3147-4cd2-ae48-b4b406a65b0a"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("255f40bb-16a3-455a-b558-e7238bc000e2"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                    new DamageEffect { Id = Guid.Parse("024061f6-ed08-4d12-a9f4-7e547d19e40b"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("9dafbeca-1a1b-42b5-b5bc-47186caf8647"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("21af795d-bfb1-477c-b893-3724811eaeed"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                    new DamageEffect { Id = Guid.Parse("76970863-6b34-4ea4-8779-4d894597688b"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("9bed9e22-354a-4d24-ae9a-4d3d9bee650f"),  ConditionId = Enfeebled.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("a15a472e-00c7-49d1-961c-3653286ac3d4"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("1cff677e-5a7a-4cd1-9ee7-1151cf963153"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                    new DamageEffect { Id = Guid.Parse("b28d1d65-738b-4537-a4dc-b4ae742f7b3c"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("42f240f3-d15d-46a4-a5ec-bc3777948cfe"),  ConditionId = Enfeebled.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fde5577d-2503-4d43-928a-228fcc34d11f"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
