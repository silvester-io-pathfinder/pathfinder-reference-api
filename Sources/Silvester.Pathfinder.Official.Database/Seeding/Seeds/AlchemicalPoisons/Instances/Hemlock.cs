using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class Hemlock : Template
    {
        public static readonly Guid ID = Guid.Parse("7c923c5c-7005-4f1b-9005-5c79b289b056");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Hemlock",
                ItemLevel = 17,
                Price = 225000,
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
                Id = Guid.Parse("9531647b-d08d-4c79-8993-c1e9fc5aebb3"),
                DifficultyCheck = 40,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "30 Minutes",
                MaximumDuration = "60 Minutes",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Ingested.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7045ff07-e29c-4f30-9a90-8d4b94e64335"), Text = "Concentrated hemlock is a particularly deadly toxin that halts muscle action—including that of the victim’s heart." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("0b046df0-35c7-4ce5-9e8a-ef267997af29"),
                Duration = "10 Minutes",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("5fe5412a-564e-4a9a-bf76-c34b7d3da595"), Damage = "17d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("6ae69ff8-919d-4a88-a8a6-b0292096d4cc"),  ConditionId = Enfeebled.ID, Severity = 2}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("a9d1a6a2-beff-45bd-8557-83718005de78"),
                Duration = "10 Minutes",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("610afeb6-7789-4aaf-b020-483aff478009"), Damage = "21d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("7762e24a-96b6-44a5-b5e6-fa0810975e64"),  ConditionId = Enfeebled.ID, Severity = 3}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("4ee75b8e-2d54-4748-abbc-280cae951532"),
                Duration = "10 Minutes",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("c239d60f-0e66-4b61-9f04-311b09d80272"), Damage = "26d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("bbd15e86-b959-4126-b304-9d7991c252bf"),  ConditionId = Enfeebled.ID, Severity = 4}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc948d2b-fe6e-4a8c-937f-ea8c597e92e5"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
