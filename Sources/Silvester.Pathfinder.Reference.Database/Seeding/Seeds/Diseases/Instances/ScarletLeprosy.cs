using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Diseases.Instances
{
    public class ScarletLeprosy : Template
    {
        public static readonly Guid ID = Guid.Parse("e2848bfd-24f3-4512-b106-d7112316b282");

        public override Disease GetDisease()
        {
            return new Disease
            {
                Id = ID,
                Name = "Scarlet Leprosy",
                Description = "Scarlet leprosy is widely feared for its devastating effects, crushing bones and organs while making recovery nearly impossible.Damage taken from scarlet leprosy can’t be healed until the disease is cured.",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DifficultyCheck = 19,
                Onset = "1 Day"
            };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65377178-dd5a-4a62-9d02-9b54f2a60ab6"),
                SourceId = GamemasteryGuide.ID,
                Page = 118
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Virulent.ID;
        }

        public override IEnumerable<DiseaseStage> GetDiseaseStages()
        {
            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new DamageDiseaseStageEffect{Damage = "2d6", DamageTypeId = DamageTypes.Instances.Bludgeoning.ID}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new DamageDiseaseStageEffect{Damage = "2d6", DamageTypeId = DamageTypes.Instances.Bludgeoning.ID},
                    new OtherDiseaseStageEffect{Effect = "Whenever you gain the wounded condition, increase the condition value by 1."}
                }
            };

            yield return new DiseaseStage
            {
                Duration = TimeSpan.FromDays(1),
                Effects = new DiseaseStageEffect[]
                {
                    new DamageDiseaseStageEffect{Damage = "4d6", DamageTypeId = DamageTypes.Instances.Bludgeoning.ID},
                    new OtherDiseaseStageEffect{Effect = "You cannot heal any Hit Point damage."}
                }
            };
        }
    }
}
