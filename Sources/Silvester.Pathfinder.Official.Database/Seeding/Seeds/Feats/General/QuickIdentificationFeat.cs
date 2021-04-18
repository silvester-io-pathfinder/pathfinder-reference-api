using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class QuickIdentificationFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("7e3b8e25-d2ad-400e-9b03-a4993d0e5f8b"),
                Name = "Quick Identification",
                Level = 2
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5cdf024f-58b7-4b4b-9170-a8b758d94618"), Type = Utilities.Text.TextBlockType.Text, Text = "You can Identify Magic swiftly. You take only 1 minute when using Identify Magic to determine the properties of an item, ongoing effect, or location, rather than 10 minutes. If you’re a master, it takes a 3-action activity, and if you’re legendary, it takes 1 action." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new OrPrerequisite
            {
                Id = Guid.Parse("e8a334d7-c372-4879-a05b-bb51803deb56"),
                Choices =
                {
                    new SkillPrerequisite { Id = Guid.Parse("95cb060c-298c-4ccb-976b-24235639f07d"), RequiredSkillId = seeder.GetSkill("Arcana"), RequiredProficiencyId = seeder.GetProficiency("Trained") },
                    new SkillPrerequisite { Id = Guid.Parse("6c8b2f5c-7fd9-4509-aa68-29f1afd16a21"), RequiredSkillId = seeder.GetSkill("Nature"), RequiredProficiencyId = seeder.GetProficiency("Trained") },
                    new SkillPrerequisite { Id = Guid.Parse("8dc0e271-020f-410a-ad89-e21ede41afe5"), RequiredSkillId = seeder.GetSkill("Occultism"), RequiredProficiencyId = seeder.GetProficiency("Trained") },
                    new SkillPrerequisite { Id = Guid.Parse("365f1d1b-d230-4213-b25c-e38ef86fad04"), RequiredSkillId = seeder.GetSkill("Religion"), RequiredProficiencyId = seeder.GetProficiency("Trained") },
                }
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
