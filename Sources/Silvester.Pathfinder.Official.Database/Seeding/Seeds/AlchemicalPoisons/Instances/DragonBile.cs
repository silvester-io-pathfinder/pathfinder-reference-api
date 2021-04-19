using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class DragonBile : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("b2e3f38f-f570-4cf8-ba74-633bdc0a1405");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Dragon Bile",
                ItemLevel = 15,
                Price = 92500,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
            };
        }

        protected override StaggeredEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("fc20616d-7ba0-49dd-94be-cf547dab680e"),
                DifficultyCheck = 37,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Minute",
                MaximumDuration = "6 Rounds",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Contact";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8d404e3-12fb-4647-adb6-60888962e8f2"), Text = "A mix of digestive juices and green dragon poison glands nauseates the victim as its flesh is digested from within." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("dadede4d-28bb-4cbc-b825-4cd8a7e1901f"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("b81c29ee-7c52-465e-87f7-70c46b8c71fe"), Damage = "6d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("35b50894-a2c7-468e-8ba0-5cd4a107b51e"),  ConditionId = Sickened.ID, Severity = 2}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("6f2a640f-b71e-4c13-a457-17767f74a6d3"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("4c826d4b-41fc-4b85-b43e-e43bd48862d6"), Damage = "7d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("049755e3-4e91-453c-981b-9ee1f657d318"),  ConditionId = Sickened.ID, Severity = 3}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("ecc2dccf-0d82-4d85-b11d-74656cec77c6"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamagePoisonStageEffect { Id = Guid.Parse("9877f704-09a9-401a-956d-26533fa67458"), Damage = "9d6", DamageTypeId = seeder.GetDamageTypeByName("Poison").Id},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("06db10c0-1c72-4baa-80d9-5ddd27243912"),  ConditionId = Sickened.ID, Severity = 4}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("6713fbf0-18f0-453e-a361-b339aafad6f3"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
