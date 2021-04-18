using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ReadLipsFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("ad4fe73a-0518-46c1-bfee-130d1b2053ab"),
                Name = "Read Lips",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe9c688e-04a1-4e87-bfea-ad1d9224efd5"), Type = Utilities.Text.TextBlockType.Text, Text = "You can read lips of others nearby who you can clearly see. When you’re at your leisure, you can do this automatically. In encounter mode or when attempting a more difficult feat of lipreading, you’re fascinated and flat-footed during each round in which you focus on lip movements, and you must succeed at a Society check (DC determined by the GM) to successfully read someone’s lips. In either case, the language read must be one that you know." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("f43e37fd-33cb-451e-89c2-a9e45e351308"), RequiredSkillId = seeder.GetSkill("Society"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
