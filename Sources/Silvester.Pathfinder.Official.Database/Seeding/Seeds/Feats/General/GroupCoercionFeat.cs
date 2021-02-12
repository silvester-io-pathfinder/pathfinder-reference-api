using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class GroupCoercionFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("ccdd4b23-9813-407e-a7a6-8bc2cdafbab5"),
                Name = "Group Coercion",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("0482965b-932e-407e-a445-337a78cb3eca"), Text = "When you Coerce, you can compare your Intimidation check result to the Will DCs of two targets instead of one. It’s possible to get a different degree of success for each target. The number of targets you can Coerce in a single action increases to four if you’re an expert, 10 if you’re a master, and 25 if you’re legendary." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("1ebd72e0-3e61-42ad-b3b7-8f68c2094de2"), RequiredSkillId = seeder.GetSkill("Intimidation"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
