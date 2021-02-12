using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryCodeBreakerFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("06f5008a-8b53-4c11-b0ec-2176e135d8b8"),
                Name = "Legendary Codebreaker",
                Level = 15
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("c92cea06-9c7d-43a4-906d-e532765fd3f2"), Text = "Your skill with languages and codes is so great that you can decipher information with little more than a quick read through a text. You can Decipher Writing using Society while reading at normal speed. If you slow down and spend the full amount of time that’s ordinarily required and roll a success, you get a critical success; if you critically succeed while spending the normal amount of time, you gain a nearly word-for-word understanding of the document." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("ad836b29-2ab7-4e76-8979-65e3f895a534"), RequiredSkillId = seeder.GetSkill("Society"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
