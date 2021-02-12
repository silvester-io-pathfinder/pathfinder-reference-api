using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class TerrifiedRetreatFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("064e540b-673f-4abb-bacc-fda48911b21a"),
                Name = "Terrified Retreat",
                Level = 7
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("d8f33acf-ba7f-4aec-a5e0-962dd317b1f8"), Text = "When you critically succeed at the Demoralize action, if the target’s level is lower than yours, the target is fleeing for 1 round." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("878125cb-4413-4304-826e-2a6f9f1e1351"), RequiredSkillId = seeder.GetSkill("Intimidation"), RequiredProficiencyId = seeder.GetProficiency("Master")};
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
