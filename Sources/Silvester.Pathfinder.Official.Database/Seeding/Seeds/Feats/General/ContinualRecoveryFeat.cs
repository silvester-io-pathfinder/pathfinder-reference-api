using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ContinualRecoveryFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("059f1e6a-f8cd-4be2-8024-ddc21dd7cd60"),
                Name = "Continual Recovery",
                Level = 2
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("ffef847d-bf3b-4b80-9e63-3a2d6714deea"), Text = "You zealously monitor a patient’s progress to administer treatment faster. When you Treat Wounds, your patient becomes immune for only 10 minutes instead of 1 hour. This applies only to your Treat Wounds activities, not any other the patient receives." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("a1321519-14ba-4357-bae3-9bdb828a3e63"), RequiredSkillId = seeder.GetSkill("Medicine"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
