using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class QuietAlliesFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("f725b35e-73bc-45b9-b5ee-6dfb225147b4"),
                Name = "Quiet Allies",
                Level = 2
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("755917de-c9d7-4d39-a1ea-9e6c72ab7885"), Text = "You’re skilled at moving with a group. When you are Avoiding Notice and your allies Follow the Expert, you and those allies can roll a single Stealth check, using the lowest modifier, instead of rolling separately. This doesn’t apply for initiative rolls." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("b3ffd080-e43c-477d-8906-54ac33624cff"), RequiredSkillId = seeder.GetSkill("Stealth"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
