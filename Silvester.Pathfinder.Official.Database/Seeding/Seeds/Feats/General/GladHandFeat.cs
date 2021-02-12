using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class GladHandFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("6f59e2f4-2100-436d-8cf8-266585faa937"),
                Name = "Glad-Hand",
                Level = 2
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("d0c298c6-63be-431c-80e9-5a95ec712f73"), Text = "First impressions are your strong suit. When you meet someone in a casual or social situation, you can immediately attempt a Diplomacy check to Make an Impression on that creature rather than needing to converse for 1 minute. You take a –5 penalty to the check. If you fail or critically fail, you can engage in 1 minute of conversation and attempt a new check at the end of that time rather than accepting the failure or critical failure result." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("0a89ce88-3517-439b-8149-414aa59fbd80"), RequiredSkillId = seeder.GetSkill("Diplomacy"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
