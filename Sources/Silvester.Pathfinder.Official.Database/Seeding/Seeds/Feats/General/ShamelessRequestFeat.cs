using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ShamelessRequestFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("3bb4c8cd-9368-43dd-92b2-99174568570a"),
                Name = "Shameless Request",
                Level = 7
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f35abd2-9e98-470e-a8a4-12ff83325793"), Type = Utilities.Text.TextBlockType.Text, Text = "You can downplay the consequences or outrageousness of your requests using sheer brazenness and charm. When you Request something, you reduce any DC increases for making an outrageous request by 2, and if you roll a critical failure for your Request, you get a failure instead. While this means you can never cause your target to reduce their attitude toward you by making a Request, they eventually tire of requests, even though they still have a positive attitude toward you." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("ca583e97-25e0-48a9-a63e-c2409c37f4f7"), RequiredSkillId = seeder.GetSkill("Diplomacy"), RequiredProficiencyId = seeder.GetProficiency("Master") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
