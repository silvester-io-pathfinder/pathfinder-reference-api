using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class BlightburnSickness : AbstractDiseaseTemplate
    {
        public static readonly Guid ID = Guid.Parse("1ff214ef-2c78-4662-89c1-b541b06c93a0");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Blightburn Sickness",
                Description = "The ceiling of the vault of the Black Desert is studded with deadly crystals that glimmer like stars above the dark sands. These crystals are radioactive and flood the vault with lethal energy. Creatures other than those native to the vault or who have survived there for a long time develop a disease called blightburn sickness. Creatures native to the Black Desert are immune, as are creatures who are affected by blightburn sickness but recover from it. The target can't recover from the disease's drained or sickened condition except by magic. The surest way to avoid contracting blightburn sickness is by wearing a blightburn ward, a piece of protective jewelry often found among urdefhans' gear or for sale in Shraen.",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 32,
                Onset = "1d4 Days",
                Spoilers = true
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26ed3169-4bdd-4ff2-8392-3ea20f036ae9"),
                SourceId = Pathfinder155.ID,
                Page = 73
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages()
        {
            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 1}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Sickened.ID, Severity = 1},
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(7),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Sickened.ID, Severity = 2},
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(31),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 3},
                    new ConditionDiseaseStageEffect { ConditionId = Sickened.ID, Severity = 3},
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(365),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Drained.ID, Severity = 4},
                    new ConditionDiseaseStageEffect { ConditionId = Sickened.ID, Severity = 3},
                }
            };
        }
    }
}
