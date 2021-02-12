using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class LastingCoercionFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("37f7d759-3c83-491a-a516-b41b64cf57a7"),
                Name = "Lasting Coercion",
                Level = 2
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("f1ce54f4-d426-4acf-bda9-645a50a04a01"), Text = "When you successfully Coerce someone, the maximum time they comply increases to a week, still determined by the GM. If you’re legendary, the maximum increases to a month." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("4e970e30-b49a-4f75-922f-fc222288a0e6"), RequiredSkillId = seeder.GetSkill("Intimidation"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
