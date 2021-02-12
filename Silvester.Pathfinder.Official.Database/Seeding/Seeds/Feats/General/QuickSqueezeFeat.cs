using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class QuickSqueezeFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("8a71ca0e-0c73-4fdd-bde7-431f3237bca6"),
                Name = "Quick Squeeze",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("605cae2e-9971-44ec-9fe2-9df99dd6fa87"), Text = "You Squeeze 5 feet per round (10 feet on a critical success). If you’re legendary in Acrobatics, you Squeeze at full Speed." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("ba0d0a02-d876-441f-9226-f270c0ed0fab"), RequiredSkillId = seeder.GetSkill("Acrobatics"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
