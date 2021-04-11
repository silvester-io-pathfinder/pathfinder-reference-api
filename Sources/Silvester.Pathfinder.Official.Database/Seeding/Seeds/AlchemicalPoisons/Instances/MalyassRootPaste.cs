using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class MalyassRootPaste : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("aef8461a-019a-4c5e-baeb-949f8ebd6e66");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Malyass Root Paste",
                ItemLevel = 7,
                Price = 5500,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("Three Actions").Id,
            };
        }

        protected override PoisonEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new PoisonEffect
            {
                Id = Guid.Parse(""),
                Name = "Malyass Root Paste",
                DifficultyCheck = 26,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Minute",
                MaximumDuration = "6 Minutes",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Contact";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("42d4e1ff-92b4-4153-b3eb-42ea8d70eb41"), Text = "Malyass root paste sees use to impede opponents in athletic competitions, in addition to espionage and tracking." };
        }

        protected override IEnumerable<PoisonEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("21b5eabd-aff1-436f-a501-1b825aecb69b"),
                Duration = "1 Minute",
                Effects = new PoisonEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("65f8e81b-a1a5-4e2e-8438-3a916d6db650"),  ConditionId = Clumsy.ID, Severity = 1},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("88e24d10-6b18-47b2-88fb-767470c877b4"),  ConditionId = WeighedDown.ID, Severity = 10},
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("0919e98f-4b60-4afe-9097-d5a5810e00b3"),
                Duration = "1 Minute",
                Effects = new PoisonEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("9b240dfe-79d6-4bc6-a125-6c270dab633b"),  ConditionId = Clumsy.ID, Severity = 2},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("9ef1187a-3825-4bd4-a0b6-b3bf8ebcd19d"),  ConditionId = WeighedDown.ID, Severity = 20},
                }
            };

            yield return new PoisonEffectStage
            {
                Id = Guid.Parse("8c04d178-f441-4fcc-82f4-57f97ab22b9d"),
                Duration = "4 Minute",
                Effects = new PoisonEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("a7046f36-0812-481c-8e53-45d094d2608a"),  ConditionId = Clumsy.ID, Severity = 3},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("1f198a30-8ab5-4d93-8750-cca7e6c55141"),  ConditionId = FlatFooted.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("cf5f02ee-0a44-4991-a7b6-454880d2d97a"),  ConditionId = WeighedDown.ID, Severity = 30},
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("2597f652-2268-4bd5-b1c3-73d4f6df3656"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 552
            };
        }
    }
}
