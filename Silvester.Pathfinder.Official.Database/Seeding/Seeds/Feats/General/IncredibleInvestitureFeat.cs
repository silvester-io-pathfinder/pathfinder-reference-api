using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class IncredibleInvestitureFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("9b475bb4-2086-4f81-b4ab-ef3f8f09f5db"),
                Name = "Incredible Investiture",
                Level = 11
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("7be3eec5-5c9b-4f76-b412-3bec0c802dd6"), Text = "You have an incredible ability to invest more magic items. Increase your limit on invested items from 10 to 12." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new StatPrerequisite { Id = Guid.Parse("11098127-44c6-4d82-9977-981fc20e637b"), RequiredStatValue = 16,  RequiredStatId = seeder.GetStat("Charisma") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
