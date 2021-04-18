using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class KipUpFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "Free";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("4f6b0041-df64-4d81-9ddd-baebcfdd28ed"),
                Name = "Kip Up",
                Level = 7
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0ff07c3-5e1e-4258-8e85-c1255b47705e"), Type = Utilities.Text.TextBlockType.Text, Text = "You stand up. This movement doesn’t trigger reactions." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("76fe7bde-7fb7-4ddf-86c5-02e226fe18fa"), RequiredSkillId = seeder.GetSkill("Acrobatics"), RequiredProficiencyId = seeder.GetProficiency("Master") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
