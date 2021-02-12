using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class SkillTrainingFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("b5a95cad-67ab-4716-b582-4a11d8b863d1"),
                CanBeLearnedMoreThanOnce = true,
                Name = "Skill Training",
                Level = 1,
                Special = "You can select this feat multiple times, choosing a new skill to become trained in each time."
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("0edf9962-598d-4813-bdef-f310458b9ea6"), Text = "You become trained in the skill of your choice." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new StatPrerequisite { Id = Guid.Parse("ab0d488c-fa87-4289-93f6-91df2166f822"), RequiredStatId = seeder.GetStat("Intellect"), RequiredStatValue = 12 };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
