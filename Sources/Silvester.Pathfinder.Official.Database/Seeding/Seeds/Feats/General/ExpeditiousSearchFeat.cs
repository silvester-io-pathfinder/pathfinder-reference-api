using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ExpeditiousSearchFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("dbd06473-8700-438f-b4e1-35474b87171c"),
                Name = "Expeditious Search",
                Level = 7
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("fd638442-dba6-4c64-a978-6076c474ffa1"), Text = "You have a system that lets you search at great speed, finding details and secrets twice as quickly as others can. When Searching, you take half as long as usual to Search a given area. This means that while exploring, you double the Speed you can move while ensuring you’ve Searched an area before walking into it (up to half your Speed). If you’re legendary in Perception, you instead Search areas four times as quickly." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("3e5994d8-c6c5-43fb-acb3-1654a1850197"), RequiredSkillId = seeder.GetSkill("Perception"), RequiredProficiencyId = seeder.GetProficiency("Master") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
        }
    }
}
