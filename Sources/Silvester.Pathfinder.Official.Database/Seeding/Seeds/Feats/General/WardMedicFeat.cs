using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class WardMedicFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("b5d31ebb-d361-4780-93c5-324bfd3c39b8"),
                Name = "Ward Medic",
                Level = 2
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8156a63f-dd8b-45e7-af35-fc4e6552a587"), Type = Utilities.Text.TextBlockType.Text, Text = "You’ve studied in large medical wards, treating several patients at once and tending to all their needs. When you use Treat Disease or Treat Wounds, you can treat up to two targets. If you’re a master in Medicine, you can treat up to four targets, and if you’re legendary, you can treat up to eight targets." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("c999f2ff-0c41-4fa7-99fb-29c166253148"), RequiredSkillId = seeder.GetSkill("Medicine"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
