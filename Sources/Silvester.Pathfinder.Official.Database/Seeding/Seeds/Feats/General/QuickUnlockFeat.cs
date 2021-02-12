using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class QuickUnlockFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("f3cdc428-01a4-4687-8d48-8de530cbd154"),
                Name = "Quick Unlock",
                Level = 7
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("7e74f923-5877-4e70-b996-be37b21a8fbc"), Text = "You can Pick a Lock using 1 action instead of 2." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("7026b01b-cf60-4cf1-a4c7-e10bed0e58f1"), RequiredSkillId = seeder.GetSkill("Thievery"), RequiredProficiencyId = seeder.GetProficiency("Master") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
