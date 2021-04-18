using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class SurveyWildlifeFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("67a42abf-7456-4bca-a74b-ef8d2fdc4459"),
                Name = "Survey Wildlife",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("af6883b2-2994-4d9a-825e-0aaf92040d99"), Type = Utilities.Text.TextBlockType.Text, Text = "You can study details in the wilderness to determine the presence of nearby creatures. You can spend 10 minutes assessing the area around you to find out what creatures are nearby, based on nests, scat, and marks on vegetation. Attempt a Survival check against a DC determined by the GM based on how obvious the signs are. On a success, you can attempt a Recall Knowledge check with a –2 penalty to learn more about the creatures just from these signs. If you’re a master in Survival, you don’t take the penalty." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("4d47f7e7-0e9c-41d8-8922-c2cb2cdc19cf"), RequiredSkillId = seeder.GetSkill("Survival"), RequiredProficiencyId = seeder.GetProficiency("Trained")};
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
