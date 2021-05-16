using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class BlackAdderVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("c65fd194-6210-42c8-80a2-b54ff81b6585");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Black Adder Venom",
                ItemLevel = 2,
                Price = 600,
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
                Id = Guid.Parse("9ab302d1-94a8-46c3-8ce5-f658e4e63531"),
                DifficultyCheck = 18,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "3 Rounds",
                Onset = "Immediate"
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
            yield return new TextBlock { Id = Guid.Parse("26dd2686-7c61-4c86-8724-6d2e336401a0"), Text = "Adder venom is a simple but effective way to enhance a weapon." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("d44a502a-e5f1-4014-899a-1b9ac8425764"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("7a7a221e-1e36-4169-9184-af24aeb92769"), Damage = "1d8", DamageTypeId = DamageTypes.Instances.Poison.ID},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("7e0f3f16-8979-426b-878a-ed4f6223a119"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("bdb667b8-4850-4ca8-837c-9b8126773640"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5033a055-e80f-43a5-b42a-14262a046351"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
