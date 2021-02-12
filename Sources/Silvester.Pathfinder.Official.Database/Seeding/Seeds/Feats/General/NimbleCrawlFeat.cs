using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class NimbleCrawlFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("df3e0135-e1de-4b1f-a580-19f521c5f328"),
                Name = "Nimble Crawl",
                Level = 2
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("614b8596-39fa-4006-903f-355857fc1e2d"), Text = "You can Crawl incredibly swiftly—up to half your Speed, rather than 5 feet. If you’re a master in Acrobatics, you can Crawl at full Speed, and if you’re legendary, you aren’t flat-footed while prone." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("8f8b340d-5aad-41ac-a4f7-160fa57e0dff"), RequiredSkillId = seeder.GetSkill("Acrobatics"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
