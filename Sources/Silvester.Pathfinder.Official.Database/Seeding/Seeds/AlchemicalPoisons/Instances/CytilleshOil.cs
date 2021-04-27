using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class CytilleshOil : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("0381fe8b-2404-42fb-9abd-74e28f1401d5");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Cytillesh Oil",
                ItemLevel = 3,
                Price = 1000,
                Usage = "Held in 1 hand",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
            };
        }

        protected override StaggeredEffect GetPoisonEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("92a84c99-95e2-4602-8a72-437137c69613"),
                DifficultyCheck = 19,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "Immediate",
                MaximumDuration = "4 Rounds"
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("062e4990-d0b3-4931-9ee3-ede80d54ec72"), Text = "This thick substance is distilled from the mind-robbing cytillesh fungus, though it lacks memory-altering capabilities." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("f7235d2a-9724-4360-985b-839bab8513c3"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("b735be5c-1040-403f-acfa-6f366435b546"), Damage = "1d10", DamageTypeId = DamageTypes.Instances.Poison.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("b3de3810-a480-4f26-9d10-b1ef0e16928e"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("6bb797d7-f7bc-4cb7-bde0-a40a77485bb1"), Damage = "1d12", DamageTypeId = DamageTypes.Instances.Poison.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("8b095b9c-c427-4860-8b1a-d012207e6877"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("a6a8aa11-5936-4b59-8935-ddfbc34ce833"), Damage = "2d10", DamageTypeId = DamageTypes.Instances.Poison.ID}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7156a518-fb39-47b8-9579-72db434fac68"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
