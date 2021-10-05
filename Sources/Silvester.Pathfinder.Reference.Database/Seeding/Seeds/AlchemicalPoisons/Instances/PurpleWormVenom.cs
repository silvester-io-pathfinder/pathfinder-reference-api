using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class PurpleWormVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("0a713a66-44df-45ff-8917-5977c0c90e8f");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Purple Worm Venom",
                ItemLevel = 13,
                Price = 50000,
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
                Id = Guid.Parse("724c0ddf-e5e3-4591-af38-154c62039b50"),
                DifficultyCheck = 32,
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
            yield return new TextBlock { Id = Guid.Parse("4de33799-27d7-42f5-a3cc-1458b3aef42d"), Text = "Venom from enormous purple worms leaves a victim weakened." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("6aeb73f9-a53b-47ff-8902-ede15b5a1650"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("05efa5dc-5e14-418c-be89-4d9f4a3500fe"), Damage = "5d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("2ba264b5-6806-41e9-9525-7b7245538a19"),  ConditionId = Enfeebled.ID, Severity = 2}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("795ce35a-f3cc-43d9-b6bb-6b9d73564c32"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("e550f252-a0e1-4e50-92ce-fbb0a02a5066"), Damage = "6d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("a4ea2ad9-1e02-4f91-bec6-15ab460cdea4"),  ConditionId = Enfeebled.ID, Severity = 2}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("ba8b6a38-0f9e-47a6-942a-858cfaaf2258"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("2c234f6c-3c55-4948-acc5-6575b4dedc72"), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("29139073-3fe6-46f0-a36a-210bd33b952d"),  ConditionId = Enfeebled.ID, Severity = 2}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c2617fd-4abd-4b17-a689-8ccb94ab206b"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
