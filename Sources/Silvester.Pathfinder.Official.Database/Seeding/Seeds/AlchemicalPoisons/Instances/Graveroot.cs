using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class Graveroot : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("b445e986-a45a-4d3a-8089-a2d33fee60dc");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Graveroot",
                ItemLevel = 3,
                Price = 1000,
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
                Id = Guid.Parse("f5edfc5f-434a-4838-889e-69265151354a"),
                DifficultyCheck = 19,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "Immediate",
                MaximumDuration = "4 Rounds",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Injury.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0b7f7c29-9473-4281-8d95-5264cfe8b23d"), Text = "The opaque white sap from the graveroot shrub clouds the mind." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("6bc9fb73-f457-44b8-b248-bcfe9d2424a5"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("6965f0cd-09aa-404b-a6a0-1a16eb74f9a6"), Damage = "1d10", DamageTypeId = DamageTypes.Instances.Poison.ID},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("29db829e-3e03-4f20-b040-1fd524fd7e68"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("50459bf2-fa21-44cc-86b3-4f58965daef7"), Damage = "1d12", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("07ba2ef2-6563-4f3f-8897-3405dfaea9ee"),  ConditionId = Stupefied.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("8d39a64f-67d5-49f9-9937-5bf5d282fc03"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("e5d81de4-9af1-4427-80fd-f804ae6534f7"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("3302a027-a721-4d57-a4c8-29b6fe7fb2cf"),  ConditionId = Stupefied.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e079a8b8-5730-481b-9ea1-f40cd189a6d3"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
