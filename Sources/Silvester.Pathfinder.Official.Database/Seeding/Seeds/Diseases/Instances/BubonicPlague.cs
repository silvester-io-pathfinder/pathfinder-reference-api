using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases.Instances
{
    public class BubonicPlague : AbstractDiseaseTemplate
    {
        public static readonly Guid ID = Guid.Parse("ab42f014-7b09-488b-a429-b2bf829cf5f2");

        public override Disease GetDisease(DiseaseSeeder seeder)
        {
            return new Disease
            {
                Id = ID,
                Name = "Bubonic Plague",
                Description = "This widespread illness can sweep through entire communities, leaving few unaffected. The first indication of the disease is a telltale swelling of glands. In some cases, the disease can move into your lungs (pneumonic plague) or blood (septicemic plague), which is even more fatal. If you have bubonic plague, you can’t remove the fatigued condition while affected.",
                SavingThrowStatId = seeder.GetSavingThrowStatByName("Fortitude").Id,
                DifficultyCheck = 17,
                Onset = "1 Day"
            };
        }

        public override SourcePage? GetSourcePage(DiseaseSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cd04e7c-ddd9-44eb-b774-cc90221b157b"),
                SourceId = GamemasteryGuide.ID,
                Page = 118
            };
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Disease";
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages(DiseaseSeeder seeder)
        {
            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 2},
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new ConditionDiseaseStageEffect { ConditionId = Enfeebled.ID, Severity = 3},
                    new ConditionDiseaseStageEffect { ConditionId = Fatigued.ID},
                    new DamageDiseaseStageEffect { DamageTypeId = seeder.GetDamageTypeByName("Bleed").Id, Every = "1d20 Minutes", IsDamagePersistent = true, Damage = "1d6"}
                }
            };
        }
    }
}
