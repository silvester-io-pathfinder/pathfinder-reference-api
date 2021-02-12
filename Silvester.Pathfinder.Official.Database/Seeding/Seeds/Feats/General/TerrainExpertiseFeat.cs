using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class TerrainExpertiseFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("17232376-8797-4f5b-bee0-2614d6938d5a"),
                Name = "Trained Expertise",
                CanBeLearnedMoreThanOnce = true,
                Level = 1,
                Special = "You can select this feat more than once, choosing a different type of terrain each time."
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("4ebf2045-8b7f-4573-8f3b-af03c404638b"), Text = "Your experience in navigating a certain type of terrain makes you supremely confident while doing so. You gain a +1 circumstance bonus to Survival checks in one of the following types of terrain, chosen when you select this feat: aquatic, arctic, desert, forest, mountain, plains, sky, swamp, or underground." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("38a9dc61-555e-48fb-a398-f72fcb139a55"), RequiredSkillId = seeder.GetSkill("Survival"), RequiredProficiencyId = seeder.GetProficiency("Trained")};
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
