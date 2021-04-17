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
    public class MindfogMist : AbstractAlchemicalPoisonTemplate
    {
        public static readonly Guid ID = Guid.Parse("c55ad542-1fba-49e6-ab84-f95050cc3d7f");

        protected override AlchemicalPoison GetAlchemicalPoison(AlchemicalPoisonSeeder seeder)
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Mindfog Mist",
                ItemLevel = 15,
                Price = 100000,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id,
            };
        }

        protected override StaggeredEffect GetPoisonEffect(AlchemicalPoisonSeeder seeder)
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("478475fe-cd71-477d-a01b-3320f4aa4a32"),
                DifficultyCheck = 35,
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                Onset = "1 Round",
                MaximumDuration = "6 Rounds",
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Poison";
            yield return "Consumable";
            yield return "Inhaled";
        }

        protected override IEnumerable<AlchemicalPoisonDetailBlock> GetDetailBlocks()
        {
            yield return new AlchemicalPoisonDetailBlock { Id = Guid.Parse("765ca329-35c6-4f20-8d10-000b35ce1a78"), Text = "Mindfog mist can be used to undermine spellcasters, as its effect on a victim’s mental faculties are swift and powerful." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages(AlchemicalPoisonSeeder seeder)
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("bbdcbd62-49d6-44fe-8bbd-dbb3af8335a0"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("bddebbfc-cc35-4a5e-b652-c0f9a83c3f49"),  ConditionId = Stupefied.ID, Severity = 2}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("ae0e2c13-d597-404b-a347-3022ee522878"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("69312c8d-fa78-4abc-8090-11990a49fbbc"),  ConditionId = Confused.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("d6ffe1a6-0373-4e2d-bc65-256555bbdf30"),  ConditionId = Stupefied.ID, Severity = 3}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("e3c7e67f-fac6-44bc-bca2-4e305a383db2"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionPoisonStageEffect { Id = Guid.Parse("07c4bb2b-a1b8-4497-bcaf-edd83a10e826"),  ConditionId = Confused.ID},
                    new ConditionPoisonStageEffect { Id = Guid.Parse("af7c7592-da0a-4afa-9a97-4a9fbe98f219"),  ConditionId = Stupefied.ID, Severity = 4}
                }
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalPoisonSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d06a375-4a3e-4487-95c1-5d207d5f98b0"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 553
            };
        }
    }
}
