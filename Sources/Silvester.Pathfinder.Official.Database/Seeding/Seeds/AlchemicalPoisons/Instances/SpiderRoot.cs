using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class SpiderRoot : Template
    {
        public static readonly Guid ID = Guid.Parse("c4f4ddce-c112-44b3-90a5-06aaaed80f1e");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Spider Root",
                ItemLevel = 9,
                Price = 11000,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override StaggeredEffect GetPoisonEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("3935e556-052d-48b8-994d-5163cf9f4ca7"),
                DifficultyCheck = 28,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "1  Minute",
                MaximumDuration = "6 Minutes",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Contact.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7891623b-6f09-4e17-b565-40ac365b6b59"), Text = "A paste made by mashing the fine, threadlike roots of a certain creeper vine, spider root renders a victim clumsy and maladroit." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("038ae784-9e97-4b76-9474-7e71f2e866f9"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("0829c1e6-8249-4419-ad41-dbd6da1aaa01"), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("d355d61d-32bb-441c-b612-2a38d98928c1"),  ConditionId = Clumsy.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("959cd97b-8af6-43d3-b464-96f192c4e0d3"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("908525b2-5ebc-4927-8cdb-2226cc29d631"), Damage = "9d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("506ecf2b-2aff-4e39-9744-10e4a502b7ed"),  ConditionId = Clumsy.ID, Severity = 2}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("cb8ec76e-2ed6-4157-9edf-eb54cc553f0b"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("26c7cf57-a9f3-4df1-8ef4-e6f296d3431c"), Damage = "10d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("b4b392eb-6f20-496f-963c-f0939043f235"),  ConditionId = Clumsy.ID, Severity = 3}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c8431c4-5db9-4ea3-8306-d4db00c4efb7"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
