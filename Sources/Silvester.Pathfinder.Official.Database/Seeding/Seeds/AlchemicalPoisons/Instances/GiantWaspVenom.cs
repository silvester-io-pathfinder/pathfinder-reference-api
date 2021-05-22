using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class GiantWaspVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("862bacf9-a11f-4f56-8c94-2452d636db79");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Giant Wasp Venom",
                ItemLevel = 7,
                Price = 5500,
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
                Id = Guid.Parse("f8e3e164-4fbf-4d88-9e99-922b4e9c26b1"),
                DifficultyCheck = 25,
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
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d4bb8d3-f0fc-4e20-a407-a73f2824d244"), Text = "Giant wasp venom interferes with a victim’s movement." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("1c67cd5b-de98-4ae0-bd21-ee9f106e14ad"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("cad292b2-f6c3-4ea9-8dd9-751959708833"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("1ddc185b-02a4-4767-b112-29d040653039"),  ConditionId = Clumsy.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("34ec0065-42d6-47b4-bf69-d973dba2ef14"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("ed57f33c-ff21-4f03-86d2-8990ac64aef9"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("fc788e66-b377-49af-b940-464150d24edf"),  ConditionId = Clumsy.ID, Severity = 2}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("c0951b2e-31d9-47da-a8d9-7d8b621fc821"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("9ba4b270-c48a-40f7-b521-37c356429c7d"), Damage = "4d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("5f9c4c7c-f785-4247-ae9c-8fe76d687bb5"),  ConditionId = Clumsy.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b2cfa04-9394-4ab9-a5ee-6dba2a814fbc"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
