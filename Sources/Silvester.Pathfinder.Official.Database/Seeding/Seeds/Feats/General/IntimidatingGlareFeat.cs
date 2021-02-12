using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class IntimidatingGlareFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("a1804dfb-e3e0-45aa-b735-2f37fed15779"),
                Name = "Intimidating Glare",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("eedd663a-d431-476d-9125-5d45f19d4ec3"), Text = "You can Demoralize with a mere glare. When you do, Demoralize loses the auditory trait and gains the visual trait, and you don’t take a penalty if the creature doesn’t understand your language." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("a4c66b29-0433-4ac7-901a-0eca0b5e793c"), RequiredSkillId = seeder.GetSkill("Intimidation"), RequiredProficiencyId = seeder.GetProficiency("Trained")};
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
