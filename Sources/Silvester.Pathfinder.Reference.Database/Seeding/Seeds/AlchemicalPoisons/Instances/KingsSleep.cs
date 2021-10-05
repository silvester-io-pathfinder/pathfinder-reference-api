using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class KingsSleep : Template
    {
        public static readonly Guid ID = Guid.Parse("7d31dbce-9230-4960-99cc-71de51c18977");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "King's Sleep",
                ItemLevel = 18,
                Price = 400000,
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
                Id = Guid.Parse("5b2e24eb-1beb-45ab-b69b-750b8f175033"),
                DifficultyCheck = 41,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "1 Day",
                MaximumDuration = "Indefinite",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Ingested.ID;
            yield return Traits.Instances.Virulent.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("620d976a-9aa5-421e-a5a0-124b60cdc8db"), Text = "King’s sleep is an insidious long-term poison that can seem like a disease or even death from natural causes on a venerable target. The drained condition from king’s sleep is cumulative with each failed save and can’t be removed while the poison lasts." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("fe6bc444-914b-49bc-93b0-1a87206e99c1"),
                Duration = "1 Day",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionEffect { Id = Guid.Parse("7e1988d4-037a-47bc-85ae-ee1234048ccf"),  ConditionId = Drained.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("14971f7b-66f5-4053-bf38-1a5a23459eea"),
                Duration = "1 Day",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionEffect { Id = Guid.Parse("bd39ba66-7b6a-4b5c-9342-66a8019a260a"),  ConditionId = Drained.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("f2ab2c28-5734-4ae9-80fc-2ebaf7481ed3"),
                Duration = "1 Day",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionEffect { Id = Guid.Parse("ebdb2091-9058-4809-bf44-87af8f639b03"),  ConditionId = Drained.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9541ee54-4d19-4904-9161-9412cd2b7905"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
