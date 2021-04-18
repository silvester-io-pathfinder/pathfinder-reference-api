using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class QuickClimbFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("2a59396f-bf2a-4075-8207-3c906b7624ff"),
                Name = "Quick Climb",
                Level = 7
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("497171c0-318e-4491-b527-ce421ee5ab7f"), Type = Utilities.Text.TextBlockType.Text, Text = "When Climbing, you move 5 more feet on a success and 10 more feet on a critical success, to a maximum of your Speed." };
            yield return new TextBlock { Id = Guid.Parse("3b09f3f6-9075-4013-9bd5-d674e3f00ffc"), Type = Utilities.Text.TextBlockType.Text, Text = "If you’re legendary in Athletics, you gain a climb Speed equal to your Speed." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("ab631681-034a-4ea2-a0fd-b847e16c7f1d"), RequiredSkillId = seeder.GetSkill("Athletics"), RequiredProficiencyId = seeder.GetProficiency("Master") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
