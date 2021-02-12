using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class StudentOfTheCanonFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("ec332db6-b06a-4a93-9935-756953f7a857"),
                Name = "Student of the Canon",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("9f681c15-5e28-4526-9a4c-aebaf2ec9179"), Text = "You’ve researched many faiths enough to recognize notions about them that are unlikely to be true. If you roll a critical failure at a Religion check to Decipher Writing of a religious nature or to Recall Knowledge about the tenets of faiths, you get a failure instead. When attempting to Recall Knowledge about the tenets of your own faith, if you roll a failure, you get a success instead, and if you roll a success, you get a critical success instead." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("c5fb8477-fe1c-40d6-b030-38bd9e545309"), RequiredSkillId = seeder.GetSkill("Religion"), RequiredProficiencyId = seeder.GetProficiency("Trained")};
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
